using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Soft.Products.Persistence
{

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
    }

    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductDbContext(DbContextOptions options) : base(options)
        {
            if (!this.Products.Any())
            {
                this.Products.Add(new Product { Id = 1, Name = "Product1", Price = 10 });
                this.Products.Add(new Product { Id = 2, Name = "Product2", Price = 20 });
                this.Products.Add(new Product { Id = 3, Name = "Product3", Price = 100 });
                this.Products.Add(new Product { Id = 4, Name = "Product4", Price = 500 });
                this.SaveChanges();
            }
        }
    }

    //public class ProductDbContext : IProductDbContext
    //{
    //    public List<Product> Products { get; set; }

    //    public ProductDbContext()
    //    {
    //        if (!this.Products.Any())
    //        {
    //            this.Products.Add(new Product { Id = 1, Name = "Product1", Price = 10 });
    //            this.Products.Add(new Product { Id = 2, Name = "Product2", Price = 20 });
    //            this.Products.Add(new Product { Id = 3, Name = "Product3", Price = 100 });
    //            this.Products.Add(new Product { Id = 4, Name = "Product4", Price = 500 });

    //        }
    //    }
    //}
}
