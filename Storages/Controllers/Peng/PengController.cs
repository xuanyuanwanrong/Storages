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
        /// <summary>
        /// 客户分页显示
        /// </summary>
        /// <param name="pageindex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult CustomerAll(int pageindex, int pageSize)
        {
            return Json(CustomerMangeng.CustomerAll(pageindex, pageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Rows()
        {
            return Json(CustomerMangeng.Rows(), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 计量单位分页显示
        /// </summary>
        /// <param name="pageindex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult MeteringAll(int pageindex, int pageSize)
        {

            return Json(MeteringMangeng.MeteringAll(pageindex, pageSize), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Rowss()
        {
            return Json(MeteringMangeng.Rowss(), JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 客户添加
        /// </summary>
        /// <param name="C"></param>
        /// <returns></returns>
        public ActionResult CustomerAdd(Customer C)
        {
            return Json(CustomerMangeng.CustomerAdd(C), JsonRequestBehavior.AllowGet);
        }

        public ActionResult CustomerCxx(string CtName)
        {
            return Json(CustomerMangeng.CustomerCxx(CtName), JsonRequestBehavior.AllowGet);
        }

      
        //删除
        //public ActionResult Del(int id)
        //{
        //    return Json(CustomerMangeng.Del(id), JsonRequestBehavior.AllowGet);

        //}
    }
}