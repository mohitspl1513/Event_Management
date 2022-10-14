using Event_Management.DBOperation;
using Event_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Event_Management.Controllers
{
    public class AccountController : Controller
    {
        Event_ManagementRep Event = null;
        public AccountController()
        {
            Event = new Event_ManagementRep();
        }
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.Customer_EntryModel model)
        {
            using (var db = new Event_ManagementEntities())
            {
                bool isValid = db.Customer_Entry.Any(x => x.Email == model.Email && x.Password == model.Password);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.Email, false);
                    return RedirectToAction("Create", "Book_Event");
                }
                ModelState.AddModelError("", "Invalid Username and Password");
                return View();
            }
        }

        public ActionResult SignUP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(Models.Customer_EntryModel model)
        {


            Event.SaveData(model);
            return RedirectToAction("Login");
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}