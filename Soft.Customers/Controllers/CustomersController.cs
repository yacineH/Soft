using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Soft.Customers.Models;
using Soft.Customers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soft.Customers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public List<CustomerModel> GetCustomers()
        {
            return customerService.GetCustomers(); 
        }
    }
}
