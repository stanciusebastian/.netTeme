using System;
using Microsoft.EntityFrameworkCore;

namespace Laborator4
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
                Database=CustomersAndEmployees;Trusted_Connection=True;");
                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().Property(c => c.Name).IsRequired().
                HasMaxLength(100);
            modelBuilder.Entity<Customer>().Property(c => c.Address).IsRequired().
                HasMaxLength(300);
        }


    }
}