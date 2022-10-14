using Event_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Event_Management.Controllers
{
    public class ADD_ON_ITEMController : Controller
    {
        // GET: ADD_ON_ITEM
        public ActionResult Index()
        {
            Event_ManagementEntities entity = new Event_ManagementEntities();
            var data = entity.ADD_ON_ITEM.ToList();
            return View(data);
        }
    }
}