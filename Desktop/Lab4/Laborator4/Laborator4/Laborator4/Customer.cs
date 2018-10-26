using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator4
{
    public class Customer
    {
        public Guid Id { get;  set; }

        public string Name { get;  set; }

        public string Address { get;  set; }

        public string PhoneNumber { get;  set; }

        public string Email { get;  set; }

        public Customer(string name, string address, string phoneNumber, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
