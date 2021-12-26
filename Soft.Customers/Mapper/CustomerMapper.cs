using AutoMapper;
using Soft.Customers.Models;
using Soft.Customers.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soft.Customers.Mapper
{
    public class CustomerMapper:Profile
    {
        public CustomerMapper()
        {
            CreateMap<Customer, CustomerModel>();
        }
    }
}
