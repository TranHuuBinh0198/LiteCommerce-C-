using LiteCommerce.BusinessLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiteCommerce.Admin.Controllers
{
    public class SupplierController : Controller
    {   
        /// <summary>
        ///  hiển thị: danh sách suppliers,  các " liên kiết" đến các chức năng liên quan
        /// </summary>
        /// <returns></returns>
        // GET: Suppliers
        public ActionResult Index(int page=1, string searchValue = "")
        {
            var listOfSuppliers = CatalogBLL.Supplier_List(1, 10, "");
            return View(listOfSuppliers);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Input( string id = "")
        {
            if (string.IsNullOrEmpty(id))
            {
                ViewBag.Title = "Add new Supplier";
            }
            else
            {
                ViewBag.Title = " Edit Supplier";
            }
            return View();
        }
    }
}