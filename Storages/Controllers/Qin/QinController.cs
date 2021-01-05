using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;
namespace Storage.Controllers.Qin
{
    public class QinController : Controller
    {
        // GET: Qin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetAll()
        {
            return View();
        }
    }
}