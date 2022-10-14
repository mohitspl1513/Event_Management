using Event_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Event_Management.Controllers
{
    public class DecorationController : Controller
    {
        // GET: Decoration
        public ActionResult Index()
        {
            Event_ManagementEntities entity = new Event_ManagementEntities();
            var data = entity.Decorations.ToList();
            ViewBag.data = data;
            return View(data);
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
    }
}