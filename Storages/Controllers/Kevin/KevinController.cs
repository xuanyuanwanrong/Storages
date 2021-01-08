using System;
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
        //public ActionResult ProductCategoryList(int PageIndex,int PageSize)
        //{
        //    return Json(ProductCategoryManager.ProductCategoryList(PageIndex, PageSize), JsonRequestBehavior.AllowGet);
        //}
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
        public ActionResult ProductList(int PageIndex, int PageSize, string PName) 
        {
            return Json(ProductManager.ProductList(PageIndex, PageSize, PName), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetProductCategory()
        {
            return Json(ProductCategoryManager.GetProductCategory(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetMetering()
        {
            return Json(MeteringManager.GetMetering(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCustomer()
        {
            return Json(CustomerManger.GetCustomer(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetWareHouse()
        {
            return Json(WareHouseManager.GetWareHouse(), JsonRequestBehavior.AllowGet);
        }
        public ActionResult ProductAdd(Product pro)
        {
            return Json(ProductManager.ProductAdd(pro), JsonRequestBehavior.AllowGet);
        }
    }
}