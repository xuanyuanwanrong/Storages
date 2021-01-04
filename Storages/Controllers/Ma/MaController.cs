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
<<<<<<< HEAD
        /// <summary>
        /// 跳转主页
        /// </summary>
        /// <returns></returns>
=======
>>>>>>> 6e20f79feae093604c43eae9d44cf58e408c7197
        public ActionResult Index()
        {
            return Redirect("Ma/index.html");
        }
    }
}