using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Userlogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Userlogin(Account objAccount)
        {
            return View();
        }
    }
}