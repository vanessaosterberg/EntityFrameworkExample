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
        public ActionResult Index(string sortOrder)
        {
            ViewBag.ConstructionMaterialSortParm = String.IsNullOrEmpty(sortOrder) ? "mat_desc" : ""; //done
            ViewBag.RadiusSortParm = sortOrder == "Rad" ? "rad_desc" : "Rad"; //done
            ViewBag.HeightSortParm = sortOrder == "Hit" ? "hit_desc" : "Hit";  //done
            ViewBag.ContentsSortParm = sortOrder == "Con" ? "con_desc" : "Con"; //done
            ViewBag.CurrentLocationSortParm = sortOrder == "Loc" ? "loc_desc" : "Loc"; //done 
            ViewBag.DateCreatedSortParm = sortOrder == "Date" ? "date_desc" : "date";
            var barrels = from s in service.GetAllBarrels()
                          select s;
            switch (sortOrder)
            {
                case "mat_desc":
                    barrels = barrels.OrderByDescending(s => s.ConstructionMaterial);
                    break;
                case "Loc":
                    barrels = barrels.OrderBy(s => s.CurrentLocation);
                    break;
                case "loc_desc":
                    barrels = barrels.OrderByDescending(s => s.CurrentLocation);
                    break;
                case "Hit":
                    barrels = barrels.OrderBy(s => s.Height);
                    break;
                case "hit_desc":
                    barrels = barrels.OrderByDescending(s => s.Height);
                    break;
                case "Rad":
                    barrels = barrels.OrderBy(s => s.Radius);
                    break;
                case "rad_desc":
                    barrels = barrels.OrderByDescending(s => s.Radius);
                    break;
                case "Con":
                    barrels = barrels.OrderBy(s => s.Contents);
                    break;
                case "con_desc":
                    barrels = barrels.OrderByDescending(s => s.Contents);
                    break;
                case "Date":
                    barrels = barrels.OrderBy(s => s.DateCreated.TimeOfDay);
                    break;
                case "date_desc":
                    barrels = barrels.OrderByDescending(s => s.DateCreated.TimeOfDay);
                    break;
                default:
                    barrels = barrels.OrderBy(s => s.ConstructionMaterial);
                    break;
            }
            return View(barrels.ToList());
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