using SBDProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBDProject.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            using(OurDbContext db = new OurDbContext())
            {
                return View(db.userAccount.ToList());
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserAccont account)
        {
            if (ModelState.IsValid)
            {
                using (OurDbContext db = new OurDbContext())
                {
                    db.userAccount.Add(account);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = account.FirstName + " " + account.LastName + " succesfully registered.";
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserAccont user)
        {
            using (OurDbContext db = new OurDbContext())
            {
                var usr = db.userAccount.Single(u => u.Login == user.Login && u.Password == user.Password);
                if(usr != null)
                {
                    Session["UserID"] = usr.UserID.ToString();
                    Session["Login"] = usr.Login.ToString();
                    return RedirectToAction("LoggenIn");
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is wrong.");
                }
            }
            return View(); 
        }

        public ActionResult LoggenIn()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}