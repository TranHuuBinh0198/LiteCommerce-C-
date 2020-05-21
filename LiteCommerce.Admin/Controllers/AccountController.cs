using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiteCommerce.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ChangePwd()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult SignOut()
        {
            Session.Abandon();
            Session.Clear();
            FormAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult Login( string email = "", string password = "")
        {
            if(Request.HttpMethod == "GET")
            {
                return View();
            }
            else
            {
                //TODO: kiểm tra thông tin đăng nhập thông qua CSDL
                if(email == "admin@abc.com" && password == "admin")
                {
                    System.Web.Security.FormsAuthentication.SetAuthCookie(email, false);
                    return RedirectToAction("Index", "Dashboard");

                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập thất bại");
                    ViewBag.Email = email;
                    return View();
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult ForgotPwd()
        {
            return View();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Suppliers()
        {
            return View();
        }
    }
}