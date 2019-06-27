using EntityFrameworkExample.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkExample.Controllers
{
    public class HomeController : Controller
    {
        public BarrelService service1 = new BarrelService();
        public CubeService service2 = new CubeService();

        public ActionResult Index()
        {
            ViewBag.Message1 = service1.TotalNumberOfBarrels();
            ViewBag.Message2 = service2.TotalNumberOfCubes();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}