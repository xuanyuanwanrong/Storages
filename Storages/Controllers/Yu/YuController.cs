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
    }
}