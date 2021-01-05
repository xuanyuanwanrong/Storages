using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.MaBLL;
using Models;
namespace Storage.Controllers.Ma
{
    public class MaController : Controller
    {
        //跳转主页
        public ActionResult Index()
        {
            return Redirect("Ma/index.html");
        }
        //查询库存清单
        public ActionResult WhAll(int PageIndex,int PageSize) {
            return Json(WarehousingManager.WhAll(PageIndex,PageSize), JsonRequestBehavior.AllowGet);
        }
        //查询所有入库类型
        public ActionResult WsTypeAll() {
            return Json(WareStateTypeManager.WsTypeAll(), JsonRequestBehavior.AllowGet);
        }
    }
}