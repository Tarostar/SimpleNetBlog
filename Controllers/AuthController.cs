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
            return View(new AuthLogin { });
        }

        [HttpPost] // explicitly directs POST here
        public ActionResult Login(AuthLogin form)
        {
            if (!ModelState.IsValid)
                return View(form);

            if (form.Username != "Claus")
            {
                ModelState.AddModelError("Username", "Username or password isn't correct");
                return View(form);
            }
            
            return Content("The form is valid");
        }
    }
}