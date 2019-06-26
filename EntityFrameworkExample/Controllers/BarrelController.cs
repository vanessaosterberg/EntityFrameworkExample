using EntityFrameworkExample.Models;
using EntityFrameworkExample.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        // GET: Barrel/Create/5
        public ActionResult Create()
        {
            return View();
        }

        // GET: Barrel/Create/5
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

        // GET: Barrel/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Barrel barrel = service.GetBarrelById((int)id);
            if (barrel == null)
            {
                return HttpNotFound();
            }
            return View(barrel);
        }

        // POST: Barrel/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Barrel barrel)
        {
            if (ModelState.IsValid)
            {
                barrel.DateCreated = (DateTime)barrel.DateCreated;
                service.SaveEdits(barrel);
                return RedirectToAction("Index");
            }
            return View(barrel);
        }

        // GET: Barrel/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Barrel barrel = service.GetBarrelById((int)id);
            if (barrel == null)
            {
                return HttpNotFound();
            }
            return View(barrel);
        }

        // POST: Barrel/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Barrel barrel = service.GetBarrelById(id);
            service.DeleteBarrel(barrel);
            return RedirectToAction("Index");
        }

    }
}