using API.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using API.ViewsModels.Customers;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly DataContext _context;

        //On connecte la BD
        public CustomerController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        [HttpPost]
        public Customer Postustomers(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        [HttpPut]
        public Customer EditCustomers(int id, CustomerEdit_VM customerEdit_VM)
        {
            //Customer customer = _context.Customers.Where(c => c.CustomerID == id).FirstOrDefault();
            //customer.CustomerUpdatedDate = DateTime.Now;
            //_context.Update(customer);
            //_context.SaveChanges();

            //return customer;

            //on recupere le customer a modifier
            var customer = _context.Customers.Where(c => c.CustomerID == id).FirstOrDefault();

            //On recupere les modifications effectuees
            customer.CustomerFirstName = customerEdit_VM.CustomerFirstName;
            customer.CustomerLaststName = customerEdit_VM.CustomerLaststName;
            customer.CustomerEmail = customerEdit_VM.CustomerEmail;
            customer.CustomerPhoneNumber = customerEdit_VM.CustomerPhoneNumber;
            customer.CustomerUpdatedDate = DateTime.Now;

            _context.Update(customer);
            _context.SaveChanges();

            return customer;
        }

        [HttpPatch]
        public void DeleteCustomers(int id)
        {
            Customer customer = _context.Customers.Where(c => c.CustomerID == id).FirstOrDefault();
            customer.CustomerState = false;
            customer.CustomerDeletedDate = DateTime.Now;
            _context.Customers.Update(customer);

            //Account account = _context.Accounts.Where(acc => acc.CustomerID == id).FirstOrDefault();
            //account.AccountState = false;
            //_context.Accounts.Update(account);

            _context.SaveChanges();
        }

    }
}
