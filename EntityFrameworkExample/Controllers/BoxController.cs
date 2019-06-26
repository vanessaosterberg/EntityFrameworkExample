using EntityFrameworkExample.Models;
using EntityFrameworkExample.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameworkExample.Controllers
{
    public class BoxController : Controller
    {
        public BoxService service = new BoxService();
        // GET: Box
        public ActionResult Index()
        {
            return View(service.GetAllBoxes());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Box boxes)
        {
            if (ModelState.IsValid)
            {
                service.AddBox(boxes);
                return RedirectToAction("Index");
            }

            return View(boxes);
        }
    }
}