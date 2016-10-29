using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FindOutMore()
        {
            return new RedirectResult(Url.Action("Index", "Home") + "#FindOutMore");
        }

    }
}