using API.Models;
using API.ViewsModels.Customers;
using System.Collections.Generic;

namespace BankApp.Services
{
    public interface ICustomerServices
    {
        public List<Customer> CustomersList();

        public List<Customer> CustomersList(bool state);

        public Customer GetCustomer(int id);

        public Customer CustomerCreate(Customer customer);

        public void CustomerDelete(int id);

        public Customer CustomerEdit( int id, CustomerEdit_VM customerEdit_VM );
    }
}
