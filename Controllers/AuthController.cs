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
            return View(new AuthLogin { Test = "This is a test value for test set in the controller" });
        }

        [HttpPost] // explicitly directs POST here
        public ActionResult Login(AuthLogin form)
        {
            form.Test = "This is the value set in the post action";
            return View();
        }
    }
}