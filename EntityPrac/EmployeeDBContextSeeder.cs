﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityPrac
{
    public class EmployeeDBContextSeeder: DropCreateDatabaseIfModelChanges<EmployeeDBContext>
    {
        protected override void Seed(EmployeeDBContext context)
        {
            Department department1 = new Department()
            {
                Name = "IT",
                Location = "New York",
                Employees = new List<Employee>()
                {
                    new Employee()
                    {
                        FirstName = "Mark",
                        LastName = "Hastings",
                        Gender = "Male",
                        Salary = 60000,
                        JobTitle = "Developer"
                    },
                    new Employee()
                    {
                        FirstName = "Ben",
                        LastName = "Hoskins",
                        Gender = "Male",
                        Salary = 70000,
                        JobTitle = "Sr. Developer"
                    },
                    new Employee()
                    {
                        FirstName = "John",
                        LastName = "Stanmore",
                        Gender = "Male",
                        Salary = 80000,
                        JobTitle = "Project Manager"
                    }
                }
            };

            Department department2 = new Department()
            {
                Name = "HR",
                Location = "London",
                Employees = new List<Employee>()
                {
                    new Employee()
                    {
                        FirstName = "Philip",
                        LastName = "Hastings",
                        Gender = "Male",
                        Salary = 45000,
                        JobTitle = "Recruiter"
                    },
                    new Employee()
                    {
                        FirstName = "Mary",
                        LastName = "Lambeth",
                        Gender = "Female",
                        Salary = 30000,
                        JobTitle = "Sr. Recruiter"
                    }
                }
            };
            Department department3 = new Department()
            {
                Name = "Payroll",
                Location = "Sydney",
                Employees = new List<Employee>()
                {
                    new Employee()
                    {
                        FirstName = "Steve",
                        LastName = "Pound",
                        Gender = "Male",
                        Salary = 45000,
                        JobTitle = "Sr. Payroll Admin",
                    },
                    new Employee()
                    {
                        FirstName = "Valarie",
                        LastName = "Vikings",
                        Gender = "Female",
                        Salary = 35000,
                        JobTitle = "Payroll Admin",
                    }
                }
            };
            context.Departments.Add(department1);
            context.Departments.Add(department2);
            context.Departments.Add(department3);

            base.Seed(context);
        }
    }
}