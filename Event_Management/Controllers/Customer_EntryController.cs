using Event_Management.DBOperation;
using Event_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Event_Management.Controllers
{
    public class Customer_EntryController : Controller
    {
        Event_ManagementRep Cust = null;
        public Customer_EntryController()
        {
            Cust = new Event_ManagementRep();
        }
        public ActionResult Index()
        {
            var data = Cust.ShowRecord();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Customer_EntryModel customer = new Customer_EntryModel();
            return View(customer);
        }
        [HttpPost]
        public ActionResult Create(Customer_EntryModel model)
        {
            Cust.SaveData(model);
            return RedirectToAction("Index");
        }
    }
}