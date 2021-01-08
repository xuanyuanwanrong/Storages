using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL.Qin;
namespace Storage.Controllers.Qin
{
    public class QinController : Controller
    {
        // GET: Qin
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 下拉列表框
        /// </summary>
        /// <returns></returns>
        public ActionResult GetSupplierType()
        {
            return Json(SupplierTypeManager.GetSupplierType(),JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public ActionResult Edit(Supplier s)
        {
            return Json(SupplierManager.Add(s),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="SlId"></param>
        /// <returns></returns>

        public ActionResult Del(int SlId)
        {
            return Json(SupplierManager.Del(SlId),JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 根据ID或者姓名查询
        /// </summary>
        /// <param name="SlId"></param>
        /// <param name="SlrName"></param>
        /// <returns></returns>
        public ActionResult GetByName(int SlId,string SlrName)
        {
            return Json(SupplierManager.GetByName(SlId, SlrName), JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 获取数据表的总行数
        /// </summary>
        /// <returns></returns>
        public ActionResult GetRows()
        {
            return Json(SupplierManager.GetRows());
        }

        /// <summary>
        /// 供应商管理分页类查询
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public ActionResult PageListDemo(int pageIndex, int pageSize, string SlrName)
        {
            return Json(SupplierManager.PageListDemo(pageIndex,pageSize, SlrName),JsonRequestBehavior.AllowGet);
        }
       
    }
}