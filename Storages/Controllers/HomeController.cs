using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL.MaBLL;
namespace Storage.Controllers
{
    public class HomeController : Controller
    {
        //跳转登录
        public ActionResult Index()
        {
            return Redirect("Ma/M_Login.html");
          
        }
        //登录
        public ActionResult Login(string name, string pwd)
        {
            User u = UserManager.Login(name, pwd);
            int num = 0;
            if (u != null)
            {
                num = 1;
                Session["jurisdiction"] = u.Jurisdiction.JdName;
            }
           
            return Json(num, JsonRequestBehavior.AllowGet);
        }
    }
}