using EntityFrameworkExample.Models;
using EntityFrameworkExample.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkExample.Controllers
{
    public class BarrelController : Controller
    {
        public BarrelService service = new BarrelService();
        // GET: Barrel
        public ActionResult Index()
        {
            return View(service.GetAllBarrels());
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Barrel toAdd)
        {
            if (ModelState.IsValid)
            {
                toAdd.DateCreated = DateTime.Now;
                service.AddBarrel(toAdd);
                return RedirectToAction("Index");
            }
            return View(toAdd);
            
        }




    }
}