﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoGalleryMVC.Areas.Default.Controllers
{
    public class ErrorController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PageNotFound()
        {
            return View();
        }
    }
}