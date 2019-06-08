using AuthenticationWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenticationWebApi.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public HomeController()
        {
        }

        public ActionResult Index()
        {
            if (!Request.IsAuthenticated)
            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.Title = "Home Page";

            var Users = db.Users.Include(u => u.Roles).Include(n => n.Nationality).Include(f => f.Faculty).ToList();
            ViewBag.Users = Users;
             
            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Title = "Login Page"; 
            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Title = "Register Page";

            return View();
        }
    }
}
