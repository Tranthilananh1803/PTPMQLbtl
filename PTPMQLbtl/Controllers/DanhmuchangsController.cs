using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PTPMQLbtl.Models;

namespace PTPMQLbtl.Controllers
{
    public class DanhmuchangsController : Controller
    {
        private PTPMQLDB db = new PTPMQLDB();
        // GET: Danhmuchangs
        public ActionResult Index()
        {
            return View(db.Danhmuchangs.ToList());
        }

        // GET: Danhmuchangs/Details/5
        [Authorize]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhmuchang danhmuchang = db.Danhmuchangs.Find(id);
            if (danhmuchang == null)
            {
                return HttpNotFound();
            }
            return View(danhmuchang);
        }

        // GET: Danhmuchangs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Danhmuchangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Mathang,Tenhang,Donvitinh,Dongia")] Danhmuchang danhmuchang)
        {
            if (ModelState.IsValid)
            {
                db.Danhmuchangs.Add(danhmuchang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(danhmuchang);
        }

        // GET: Danhmuchangs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhmuchang danhmuchang = db.Danhmuchangs.Find(id);
            if (danhmuchang == null)
            {
                return HttpNotFound();
            }
            return View(danhmuchang);
        }

        // POST: Danhmuchangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Mathang,Tenhang,Donvitinh,Dongia")] Danhmuchang danhmuchang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danhmuchang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(danhmuchang);
        }

        // GET: Danhmuchangs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danhmuchang danhmuchang = db.Danhmuchangs.Find(id);
            if (danhmuchang == null)
            {
                return HttpNotFound();
            }
            return View(danhmuchang);
        }

        // POST: Danhmuchangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Danhmuchang danhmuchang = db.Danhmuchangs.Find(id);
            db.Danhmuchangs.Remove(danhmuchang);
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
