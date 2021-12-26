using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soft.Customers.Persistence
{

    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class CustomerDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CustomerDbContext(DbContextOptions options):base(options)
        {
            if(!this.Customers.Any())
            {
                this.Customers.Add(new Customer { Id = 1, Name = "Customer 1" });
                this.Customers.Add(new Customer { Id = 2, Name = "Customer 2" });
                this.Customers.Add(new Customer { Id = 3, Name = "Customer 3" });
                this.Customers.Add(new Customer { Id = 4, Name = "Customer 4" });
                this.SaveChanges();
            }

        }

    }
}
