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
        

        //查询待审核
        public ActionResult SelectRuKuDSH(int pageIndex, int PageSize)
        {
            return Json(RuKumanager.SelectRuKuDSH(pageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 入库单查询审核成功
        //获取入库单总条数
        

        //查询待审核
        public ActionResult SelectRuKuSHCG(int pageIndex, int PageSize)
        {
            return Json(RuKumanager.SelectRuKuSHCG(pageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 入库单查询审核失败
        //获取入库单总条数
       

        //查询待审核
        public ActionResult SelectRuKuSHSB(int pageIndex, int PageSize)
        {
            return Json(RuKumanager.SelectRuKuSHSB(pageIndex, PageSize), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region  入库单条件查询

        #region 根据入库单号查询
       

        public ActionResult SelectRuKuID(int pageIndex, int PageSize, int id)
        {
            return Json(RuKumanager.SelectRuKuID(pageIndex, PageSize,id), JsonRequestBehavior.AllowGet);
        }

        //查询待审核
        public ActionResult SelectRuKuDSHId(int pageIndex, int PageSize, int id)
        {
            return Json(RuKumanager.SelectRuKuDSHId(pageIndex, PageSize, id), JsonRequestBehavior.AllowGet);
        }

        //查询审核成功
        public ActionResult SelectRuKuSHCGId(int pageIndex, int PageSize, int id)
        {
            return Json(RuKumanager.SelectRuKuSHCGId(pageIndex, PageSize, id), JsonRequestBehavior.AllowGet);
        }

        //查询审核失败
        public ActionResult SelectRuKuSHSBId(int pageIndex, int PageSize, int id)
        {
            return Json(RuKumanager.SelectRuKuSHSBId(pageIndex, PageSize, id), JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 根据入库时间查询
        //所有
        public ActionResult SelectRuKuTime(int pageIndex, int PageSize, DateTime timeL, DateTime timeR)
        {
            return Json(RuKumanager.SelectRuKuTime(pageIndex, PageSize, timeL,timeR), JsonRequestBehavior.AllowGet);
        }
        //查询待审核
        public ActionResult SelectRuKuDSHTime(int pageIndex, int PageSize, DateTime timeL, DateTime timeR)
        {
            return Json(RuKumanager.SelectRuKuDSHTime(pageIndex, PageSize, timeL, timeR), JsonRequestBehavior.AllowGet);
        }

        //查询审核成功
        public ActionResult SelectRuKuSHCGTime(int pageIndex, int PageSize, DateTime timeL, DateTime timeR)
        {
            return Json(RuKumanager.SelectRuKuSHCGTime(pageIndex, PageSize, timeL, timeR), JsonRequestBehavior.AllowGet);
        }

        //查询审核失败
        public ActionResult SelectRuKuSHSBTime(int pageIndex, int PageSize, DateTime timeL, DateTime timeR)
        {
            return Json(RuKumanager.SelectRuKuSHSBTime(pageIndex, PageSize, timeL, timeR), JsonRequestBehavior.AllowGet);
        }
        #endregion
        #region 两者查询
        public ActionResult SelectRuKuIDTime(int pageIndex, int PageSize, DateTime timeL, DateTime timeR, int id)
        {
            return Json(RuKumanager.SelectRuKuIDTime(pageIndex, PageSize, timeL, timeR,id), JsonRequestBehavior.AllowGet);
        }

        //查询待审核
        public ActionResult SelectRuKuDSHTimeId(int pageIndex, int PageSize, DateTime timeL, DateTime timeR, int id)
        {
            return Json(RuKumanager.SelectRuKuDSHTimeId(pageIndex, PageSize, timeL, timeR, id), JsonRequestBehavior.AllowGet);
        }

        //查询审核成功
        public ActionResult SelectRuKuSHCGTimeId(int pageIndex, int PageSize, DateTime timeL, DateTime timeR, int id)
        {
            return Json(RuKumanager.SelectRuKuSHCGTimeId(pageIndex, PageSize, timeL, timeR, id), JsonRequestBehavior.AllowGet);
        }

        //查询审核失败
        public ActionResult SelectRuKuSHSBTimeId(int pageIndex, int PageSize, DateTime timeL, DateTime timeR, int id)
        {
            return Json(RuKumanager.SelectRuKuSHSBTimeId(pageIndex, PageSize, timeL, timeR, id), JsonRequestBehavior.AllowGet);
        }
        #endregion
        #endregion
    }
}