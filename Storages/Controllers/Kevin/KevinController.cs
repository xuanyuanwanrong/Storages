using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Kevin;

namespace Storage.Controllers.Kevin
{
    public class KevinController : Controller
    {
        // GET: Kevin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ProductCategoryList(int PageIndex,int PageSize)
        {
            return Json(ProductCategoryManager.ProductCategoryList(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
    }
}