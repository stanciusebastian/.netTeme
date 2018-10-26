using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laborator4
{
    public class EmployeesRepository
    {
        private readonly ApplicationContext context;

        public EmployeesRepository()
        {
            this.context = new ApplicationContext();
        }

        public void Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            context.Employees.Remove(employee);
            context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return (this.context.Employees).ToList();
        }

        public Employee GetEmployeeByEmail(string email)
        {
            return this.context.Employees.First(c => c.Email == email);
        }

        public List<Employee> GetEmployeeBySalary(double salary)
        {
            return (this.context.Employees.Where(c => c.Salary == salary)).ToList();
        }
    }
}
