using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ITSProject.Models;
using Microsoft.AspNet.Identity;

namespace ITSProject.Controllers
{
    public class SkolaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Skola
        [Authorize]
        public ActionResult Index()
        {
            return View(db.Skolas.ToList());
        }

        // GET: Skola/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skola skola = db.Skolas.Find(id);
            if (skola == null)
            {
                return HttpNotFound();
            }
            return View(skola);
        }

        // GET: Skola/Create
        [Authorize(Roles = "Admin,Employee")] //skolu moze da vidi i pravi admin i employee
        public ActionResult Create()
        {
            return View();
        }

		// POST: Skola/Create 
		[HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles="Admin,Employee")]
        public ActionResult Create([Bind(Include = "Id,Naziv,AdresaReg,Opstina,PostanskiBroj,MaticniBroj,PIB,BrojRacuna,WebStranica,Pecat,Beleska")] Skola skola)
        {
            if (ModelState.IsValid)
            {

				skola.ApplicationUserID = User.Identity.GetUserId();
				db.Skolas.Add(skola);
				
				db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(skola);
        }

        // GET: Skola/Edit/5
        [Authorize(Roles = "Admin,Employee")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skola skola = db.Skolas.Find(id);
            if (skola == null)
            {
                return HttpNotFound();
            }
            return View(skola);
        }

        // POST: Skola/Edit/5
        [HttpPost]
        [Authorize(Roles = "Admin,Employee")]
        [ValidateAntiForgeryToken]
		public ActionResult Edit([Bind(Include = "Id,Naziv,AdresaReg,Opstina,PostanskiBroj,MaticniBroj,PIB,BrojRacuna,WebStranica,Pecat,Beleska")] Skola skola)
        {
            if (ModelState.IsValid)
            {
                db.Entry(skola).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(skola);
        }

		// GET: Skola/Delete/5
        [Authorize(Roles="Admin")] 
		public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Skola skola = db.Skolas.Find(id);
            if (skola == null)
            {
                return HttpNotFound();
            }
            return View(skola);
        }

        // POST: Skola/Delete/5//
        [Authorize(Roles="Admin")]
		[HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Skola skola = db.Skolas.Find(id);
            db.Skolas.Remove(skola);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
