using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace Simple_WebAPI.Controllers
{
   
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
