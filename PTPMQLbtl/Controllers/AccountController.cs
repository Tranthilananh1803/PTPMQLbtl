using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using PTPMQLbtl.Models;

namespace PTPMQLbtl.Controllers
{
    public class AccountController : Controller
    {
        Encrytion encry = new Encrytion();
        PTPMQLDB db = new PTPMQLDB();
        // GET: Account
       [HttpGet ]
       public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Register(Account acc)
        { if (ModelState.IsValid)
            {
                // mã hóa mật khẩu trước khi lưu vào database
                acc.Password = encry.PasswordEncrytion(acc.Password);
                db.Accounts.Add(acc);
                db.SaveChanges();
                return RedirectToAction("Login", "Account");
            }    
            return View(acc);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login (Account acc)
        {
            if (ModelState.IsValid)
            {
                String encrytionpass = encry.PasswordEncrytion(acc.Password);
                var model = db.Accounts.Where(m => m.Usename == acc.Usename && m.Password == encrytionpass).ToList().Count();
                if(model==1)
                {
                    FormsAuthentication.SetAuthCookie(acc.Usename, true);
                    return RedirectToAction("Index", "Home");

                }    
                else
                {
                    ModelState.AddModelError("", "Thông tin đăng nhập không chính xác");

                }                    
            }
            return View(acc);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}