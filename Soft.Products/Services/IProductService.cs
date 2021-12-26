using Soft.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soft.Products.Services
{
    public interface IProductService
    {
        List<ProductModel> GetProducts();
        ProductModel GetProduct(int id);
    }
}
