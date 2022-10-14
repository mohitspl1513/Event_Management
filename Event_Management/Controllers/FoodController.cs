using Event_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Event_Management.Controllers
{
    public class FoodController : Controller
    {
        // GET: Food
        public ActionResult Index()
        {
            Event_ManagementEntities entity = new Event_ManagementEntities();
            var data = entity.Foods.ToList();
            return View(data);
        }
    }
}