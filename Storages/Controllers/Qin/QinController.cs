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
            return Redirect("Qin/Q_member-list");
        }
        public ActionResult GetAll()
        {
            //return Json();
        }
    }
}