using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Storage.Controllers.Ma
{
    public class MaController : Controller
    {
        // GET: Ma
        public ActionResult Index()
        {
            return Redirect("Ma/index.html");
        }
    }
}