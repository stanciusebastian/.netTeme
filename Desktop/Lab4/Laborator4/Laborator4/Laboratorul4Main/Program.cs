using System;
using Laborator4;

namespace Laboratorul4Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var CusRepository = new CustomersRepository();
            var EmplRepository = new EmployeesRepository();
            var Customer = new Customer("Stanciu", "Aleea", "0323", "sebastian_s97@yahoo.ro");
            var Employee = new Employee("Sss", "jfjaj", new DateTime(2010, 8, 18), new DateTime(2012, 5, 29), true, 2302, "sjsjej@yahoo.com");
            CusRepository.Add(customer: Customer);
        }
    }
}
