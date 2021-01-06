﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.Kevin;
using Models;

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
        public ActionResult ProductCategoryAdd(ProductCategory pro)
        {
            return Json(ProductCategoryManager.ProductCategoryAdd(pro), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ProductCategoryDel(int PcId)
        {
            return Json(ProductCategoryManager.ProductCategoryDel(PcId), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ProductCategoryByPcid(int Pcid)
        {
            return Json(ProductCategoryManager.ProductCategoryByPcid(Pcid), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ProductCategoryUpd(ProductCategory pro)
        {
            return Json(ProductCategoryManager.ProductCategoryUpd(pro), JsonRequestBehavior.AllowGet);
        }
    }
}