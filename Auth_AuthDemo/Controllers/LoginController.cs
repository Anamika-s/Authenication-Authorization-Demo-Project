using Auth_AuthDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Auth_AuthDemo.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Login(string txtUserName, string txtPassword)
        {
            SalesDbContext db = new SalesDbContext();

            User user = db.Users.FirstOrDefault(x =>  x.Username == txtUserName && x.Password == txtPassword);
            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(txtUserName, false);
                FormsAuthentication.RedirectFromLoginPage(txtUserName, true);
            }
                return RedirectToAction("Index", "Products");
          }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
            }
}