using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laborator4
{
    public class CustomersRepository
    {
        private readonly ApplicationContext context;

        public CustomersRepository()
        {
            this.context = new ApplicationContext();
        }

        public void Create()
        {
            this.context = new ApplicationContext();
        }

        public void Add(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public void Delete(Customer customer)
        {
            context.Customers.Remove(customer);
            context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            var existingCustomer = this.context.Customers.First(c => c.Id == customer.Id);
            existingCustomer.Name = customer.Name;
            existingCustomer.Address = customer.Address;
            existingCustomer.PhoneNumber = customer.PhoneNumber;
            existingCustomer.Email = customer.Email;
        }

        public List<Customer> GetAll()
        {
            return (this.context.Customers).ToList();
        }

        public Customer GetCustomerByEmail(string email)
        {
            return this.context.Customers.First(c => c.Email == email);
        }

    }
}
