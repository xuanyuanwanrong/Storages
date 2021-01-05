using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL.Peng;
namespace Storage.Controllers.Peng
{
    public class PengController : Controller
    {
        // GET: Peng
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CustomerAll(int pageindex, int pageSize) {
            return Json(CustomerMangeng.CustomerAll(pageindex, pageSize),JsonRequestBehavior.AllowGet);
        }
        public ActionResult Rows() {
            return Json(CustomerMangeng.Rows(),JsonRequestBehavior.AllowGet);
        }
    }
}