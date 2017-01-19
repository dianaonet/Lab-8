using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult SomeMethodName()
        {
            return View("");
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}