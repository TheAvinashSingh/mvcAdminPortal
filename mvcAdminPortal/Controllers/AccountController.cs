using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcAdminPortal.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(string username, string password)
        {
            if( username.Equals("admin") && password.Equals("admin"))
            {
                Session["username"] = username;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.error = "Incorrect Credentials";
                return View("Index");
            }
        }
        [HttpGet]
        public ActionResult Logout()
        {
            Session.Remove("username");
            return RedirectToAction("Index");
        }
    }
}