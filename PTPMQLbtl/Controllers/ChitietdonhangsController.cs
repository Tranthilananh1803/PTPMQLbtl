using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PTPMQLbtl.Models;

namespace PTPMQLbtl.Controllers
{
    public class DonhanghoasController : Controller
    {
        private PTPMQLDB db = new PTPMQLDB();

        // GET: Donhanghoas
        public ActionResult Index()
        {
            return View(db.Donhangs.ToList());
        }

        // GET: Donhanghoas/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chitietdonhang donhanghoa = db.Donhangs.Find(id);
            if (donhanghoa == null)
            {
                return HttpNotFound();
            }
            return View(donhanghoa);
        }

        // GET: Donhanghoas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Donhanghoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Madonhang,Tendonhang,Sodonhang,Yeucau")] Chitietdonhang donhanghoa)
        {
            if (ModelState.IsValid)
            {
                db.Donhangs.Add(donhanghoa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(donhanghoa);
        }

        // GET: Donhanghoas/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chitietdonhang donhanghoa = db.Donhangs.Find(id);
            if (donhanghoa == null)
            {
                return HttpNotFound();
            }
            return View(donhanghoa);
        }

        // POST: Donhanghoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Madonhang,Tendonhang,Sodonhang,Yeucau")] Chitietdonhang donhanghoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donhanghoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(donhanghoa);
        }

        // GET: Donhanghoas/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chitietdonhang donhanghoa = db.Donhangs.Find(id);
            if (donhanghoa == null)
            {
                return HttpNotFound();
            }
            return View(donhanghoa);
        }

        // POST: Donhanghoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Chitietdonhang donhanghoa = db.Donhangs.Find(id);
            db.Donhangs.Remove(donhanghoa);
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
