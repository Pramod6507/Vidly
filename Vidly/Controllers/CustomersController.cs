using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customersList = new List<Customer>();
            customersList.Add(new Customer {Name = "John Smith", Id = 1});
            customersList.Add(new Customer { Name = "Mary Williams", Id = 2 });
            return View(customersList);
        }

        public ActionResult Details(int id)
        {
            
            var customer = new Customer();
            var customersList = new List<Customer>();
            customersList.Add(new Customer { Name = "John Smith", Id = 1 });
            customersList.Add(new Customer { Name = "Mary Williams", Id = 2 });

            if(id<=customersList.Count & id>0)
                customer = customersList[id-1];
            else
                customer.Name = "No user at this address";
            
            return View(customer);
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}