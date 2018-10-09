using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityPrac
{
    public class EmployeeDBContext:DbContext
    {
        //public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().MapToStoredProcedures(
                         p=>p.Insert(i=>i.HasName("sp_InsertEmp")
                         .Parameter(n=>n.Name,"EmpName")
                         .Parameter(g=>g.Gender, "EmpGender")
                         .Parameter(s=>s.Salary, "EmpSalary"))
                         .Update(u=>u.HasName("sp_UpdateEmp")
                        .Parameter(n => n.Name, "EmpName")
                         .Parameter(g => g.Gender, "EmpGender")
                         .Parameter(s => s.Salary, "EmpSalary"))
                         .Delete(d=>d.HasName("sp_DeleteEmp")
                         .Parameter(i=>i.Id,"EmpId")));
            base.OnModelCreating(modelBuilder);
        }

    }
}