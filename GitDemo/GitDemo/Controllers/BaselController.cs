using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitDemo.Controllers
{
    public class BaselController : Controller
    {
        // GET: Basel
        public ActionResult Index()
        {
            return View();
        }
    }
}