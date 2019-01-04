using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDay1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string LoginID,string Password)
        {
            if(LoginID=="user1" && Password=="pass@123")
            {
                Session["loginID"] = LoginID;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.msg = "Invalid ID or Password";
                return View();
            }
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewUser(string EmailID,string Password,string Name, string City)
        {
            //ADO.NET or Model
            return View("View_CustomerCreated");
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Home");//GET
        }
    }
}