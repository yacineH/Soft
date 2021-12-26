using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Soft.Products.Models;
using Soft.Products.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soft.Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public List<ProductModel> GetProducts()
        {
            return productService.GetProducts();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<ProductModel> GetProduct(int id)
        {
            var item = productService.GetProduct(id);

            if (item is null) return NotFound();

            return item;
        }

    }
}
