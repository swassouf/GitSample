using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitDemo.Controllers
{
    public class SamController : Controller
    {
        // GET: Sam
        public ActionResult Default()
        {
            return View();
        }

        public ActionResult GetMethod1()
        {
            return View();
        }
    }
}