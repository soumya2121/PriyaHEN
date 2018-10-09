using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace EntityPrac
{
    public class EmployeeRepository
    {
        EmployeeDBContext employeeDBContext = new EmployeeDBContext();
        public List<Employee> GetEmployees()
        {
           
            return employeeDBContext.Employees.ToList();
        }

        public void InsertEmployee(Employee employee)
        {
            employeeDBContext.Employees.Add(employee);
            employeeDBContext.SaveChanges();
        }
        public void UpdateEmployee(Employee employee)
        {
            var Employee=employeeDBContext.Employees.SingleOrDefault(x => x.Id == employee.Id);
            Employee.Id = employee.Id;
            Employee.Name = employee.Name;
            Employee.Gender = employee.Gender;
            Employee.Salary = employee.Salary;
            employeeDBContext.SaveChanges();
        }
        public void DeleteEmployee(Employee employee)
        {
            var Employee = employeeDBContext.Employees.SingleOrDefault(x => x.Id == employee.Id);
            employeeDBContext.Employees.Remove(Employee);
            employeeDBContext.SaveChanges();
        }
    }
}