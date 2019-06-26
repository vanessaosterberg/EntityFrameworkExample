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
    public class CubeController : Controller
    {

        public CubeService service = new CubeService();

        // GET: Cube
        public ActionResult Index()
        {
            return View(service.GetAllCubes());
        }


        // GET: Cube/Create/5
        public ActionResult Create()
        {
            return View();
        }

        // GET: Cube/Create/5
        [HttpPost]
        public ActionResult Create(Cube toAdd)
        {
            if (ModelState.IsValid)
            {
                toAdd.DateCreated = DateTime.Now;
                service.AddCube(toAdd);
                return RedirectToAction("Index");
            }
            return View(toAdd);

        }

        // GET: Cube/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cube cube = service.GetCubeById((int)id);
            if (cube == null)
            {
                return HttpNotFound();
            }
            return View(cube);
        }

        // POST: Cube/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cube cube)
        {
            if (ModelState.IsValid)
            {
                service.SaveEdits(cube);
                return RedirectToAction("Index");
            }
            return View(cube);
        }

        // GET: Cube/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cube cube = service.GetCubeById((int)id);
            if (cube == null)
            {
                return HttpNotFound();
            }
            return View(cube);
        }

        // POST: Cube/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cube cube = service.GetCubeById(id);
            service.DeleteCube(cube);
            return RedirectToAction("Index");
        }






    }
}