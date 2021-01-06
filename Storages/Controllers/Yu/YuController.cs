using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL.Lxy;

namespace Storage.Controllers.Yu
{
    public class YuController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        #region  入库单查询所有
        ///<summary>
        ///获取入库单总条数
        /// </summary>

        public ActionResult RuKuRows()
        {
            return Json(RuKumanager.RuKuRows(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SelectRuKuAll(int pageIndex, int PageSize)
        {
            return Json(RuKumanager.SelectRuKuAll(pageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 入库单查询待审核
        //获取入库单总条数
        public ActionResult RuKuDSHRows()
        {
            return Json(RuKumanager.RuKuDSHRows(), JsonRequestBehavior.AllowGet);
        }

        //查询待审核
        public ActionResult SelectRuKuDSH(int pageIndex, int PageSize)
        {
            return Json(RuKumanager.SelectRuKuDSH(pageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 入库单查询审核成功
        //获取入库单总条数
        public ActionResult RuKuSHCGRows()
        {
            return Json(RuKumanager.RuKuSHCGRows(), JsonRequestBehavior.AllowGet);
        }

        //查询待审核
        public ActionResult SelectRuKuSHCG(int pageIndex, int PageSize)
        {
            return Json(RuKumanager.SelectRuKuSHCG(pageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 入库单查询审核失败
        //获取入库单总条数
        public ActionResult RuKuSHSBRows()
        {
            return Json(RuKumanager.RuKuSHSBRows(), JsonRequestBehavior.AllowGet);
        }

        //查询待审核
        public ActionResult SelectRuKuSHSB(int pageIndex, int PageSize)
        {
            return Json(RuKumanager.SelectRuKuSHSB(pageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region  入库单条件查询

        #region 根据入库单号查询
        public ActionResult RuKuIDRows(int id)
        {
            return Json(RuKumanager.RuKuIDRows(id), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SelectRuKuID(int pageIndex, int PageSize, int id)
        {
            return Json(RuKumanager.SelectRuKuID(pageIndex, PageSize,id), JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion
    }
}