using Event_Management.DBOperation;
using Event_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Event_Management.Controllers
{
    [Authorize]
    public class Book_EventController : Controller
    {
        Event_ManagementRep book_Event = null;
        public Book_EventController()
        {
            book_Event = new Event_ManagementRep();
        }
        public ActionResult Index()
        {
            var data = book_Event.ShowData();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Book_EventModel book_Event = new Book_EventModel();
            Event_ManagementEntities db = new Event_ManagementEntities();
            var decorationList = db.Decorations.ToList();
            var foodList = db.Foods.ToList();
            var addonitemList = db.ADD_ON_ITEM.ToList();
            ViewBag.decoration = decorationList;
            ViewBag.food = foodList;
            ViewBag.addonitem = addonitemList;

            return View(book_Event);
        }
        [HttpPost]
        public ActionResult Create(Book_EventModel model)
        {
            book_Event.Save(model);
            return RedirectToAction("Index");
        }
        
        
    }
}