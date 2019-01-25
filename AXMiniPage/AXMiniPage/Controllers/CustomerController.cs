using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AXMiniPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace AXMiniPage.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Orders()
        {
            //create model and populate fields
            CustomerViewModel model = new CustomerViewModel();
            model.FirstName = "John";
            model.LastName = "Smith";
            model.CustomerNumber = 111111;

            //create and add order1
            CustomerOrder order1 = new CustomerOrder();
            order1.OrderId = 1;
            order1.Description = "Part 1";
            order1.Total = 10;
            order1.OrderDate = DateTime.Now;
            model.Orders.Add(order1);

            //create and add order2 
            CustomerOrder order2 = new CustomerOrder();
            order2.OrderId = 2;
            order2.Description = "Part 2";
            order2.Total = 20;
            order2.OrderDate = DateTime.Now;
            model.Orders.Add(order2);

            //create and add order3
            CustomerOrder order3 = new CustomerOrder();
            order3.OrderId = 3;
            order3.Description = "Part 3";
            order3.Total = 30;
            order3.OrderDate = DateTime.Now;
            model.Orders.Add(order3);

            return View(model);
        }
    }
}