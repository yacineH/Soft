using AutoMapper;
using Soft.Products.Models;
using Soft.Products.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soft.Products.Services
{
    public class ProductService:IProductService
    {
        private readonly IMapper mapper;
        private readonly ProductDbContext productDbcontext;

        public ProductService(ProductDbContext productDbContext,IMapper mapper)
        {
            this.mapper = mapper;
            this.productDbcontext = productDbContext;
        }

        public List<ProductModel> GetProducts()
        {
           return mapper.Map<List<ProductModel>>(productDbcontext.Products.ToList());

        }

        public ProductModel GetProduct(int id)
        {
          return mapper.Map<ProductModel>(productDbcontext.Products.FirstOrDefault(x => x.Id == id));
        }

    }
}
