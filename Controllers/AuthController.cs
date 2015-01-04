using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.ViewModels;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        // default for  GET
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost] // explicitly directs POST here
        public ActionResult Login(AuthLogin form)
        {
            return Content("Hi there " + form.Username);
        }
    }
}