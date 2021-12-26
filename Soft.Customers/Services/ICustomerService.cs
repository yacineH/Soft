using Soft.Customers.Models;
using System.Collections.Generic;



namespace Soft.Customers.Services
{
    public interface ICustomerService
    {
        List<CustomerModel> GetCustomers();
    }
}