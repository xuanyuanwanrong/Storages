﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Storage.Controllers.Ma
{
    public class MaController : Controller
    {
        //跳转主页
        public ActionResult Index()
        {
            return Redirect("Ma/index.html");
        }
    }
}