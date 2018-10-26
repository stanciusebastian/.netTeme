using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Laborator4
{
    public class Employee
    {
        public Guid Id { get; private set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; private set; }

        [Required]
        [StringLength(70)]
        public string LastName { get; private set; }

        [Required]
        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public bool IsActive { get; private set; }

        public double Salary { get; private set; }

        public string Email { get; private set; }

        public Employee(string firstName, string lastName, DateTime startDate, DateTime endDate, bool isActive, double salary,string email)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            StartDate = startDate;
            EndDate = endDate;
            IsActive = isActive;
            Salary = salary;
            Email = email;
        }
    }
}
