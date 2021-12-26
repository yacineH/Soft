using AutoMapper;
using Soft.Customers.Models;
using Soft.Customers.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soft.Customers.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly CustomerDbContext customerDbContext;
        private readonly IMapper mapper;

        public CustomerService(CustomerDbContext customerDbContext,IMapper mapper)
        {
            this.customerDbContext = customerDbContext;
            this.mapper = mapper;
        }

        public List<CustomerModel> GetCustomers()
        {
            return  mapper.Map<List<CustomerModel>>(customerDbContext.Customers.ToList());
        }
    }
}
