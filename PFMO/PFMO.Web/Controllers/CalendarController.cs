﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PFMO.Web.Controllers
{
    public class CalendarController : ApplicationBaseController
    {
        // GET: Calendar
        public ActionResult Index()
        {
            return View();
        }
    }
}