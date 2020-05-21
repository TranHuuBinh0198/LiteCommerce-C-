using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiteCommerce.Admin.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Input(string id = "")
        {
            if(string.IsNullOrEmpty(id))
            {
                ViewBag.Title = " Add New Customer";
            }
            else
            {
                ViewBag.Title = "Edit Customer";
            }
            return View();
        }
    }
}