using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SuperHeroesWebSite.Models;

namespace SuperHeroesWebSite.Controllers
{
    public class SuperHeroesController : Controller
    {
        private SuperHeroesDataContext db = new SuperHeroesDataContext();

        // GET: SuperHeroes
        public ActionResult Index()
        {
            return View(db.SuperHeroes.ToList());
        }

        // GET: SuperHeroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuperHero superHero = db.SuperHeroes.Find(id);
            if (superHero == null)
            {
                return HttpNotFound();
            }
            return View(superHero);
        }

        // GET: SuperHeroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperHeroes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,ImageUri")] SuperHero superHero)
        {
            if (ModelState.IsValid)
            {
                db.SuperHeroes.Add(superHero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(superHero);
        }

        // GET: SuperHeroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuperHero superHero = db.SuperHeroes.Find(id);
            if (superHero == null)
            {
                return HttpNotFound();
            }
            return View(superHero);
        }

        // POST: SuperHeroes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,ImageUri")] SuperHero superHero)
        {
            if (ModelState.IsValid)
            {
                db.Entry(superHero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(superHero);
        }

        // GET: SuperHeroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SuperHero superHero = db.SuperHeroes.Find(id);
            if (superHero == null)
            {
                return HttpNotFound();
            }
            return View(superHero);
        }

        // POST: SuperHeroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SuperHero superHero = db.SuperHeroes.Find(id);
            db.SuperHeroes.Remove(superHero);
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
