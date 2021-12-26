using AutoMapper;
using Soft.Products.Models;
using Soft.Products.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soft.Products.Mapper
{
    public class ProductMapper :Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, ProductModel>();   
        }
    }
}
