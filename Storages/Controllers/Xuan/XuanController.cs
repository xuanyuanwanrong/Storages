using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL.LiuYingXuan;

namespace Storage.Controllers.Xuan
{
    public class XuanController : Controller
    {
        // GET: Xuan
        public ActionResult Index()
        { 
            return View();
        }

        public ActionResult GetWareHouse()
        {
            return Json(WareHouseManager.GetWareHouse(), JsonRequestBehavior.AllowGet);
        }
    }
}