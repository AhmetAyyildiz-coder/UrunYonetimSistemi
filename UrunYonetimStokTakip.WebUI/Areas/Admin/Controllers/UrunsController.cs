using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UrunYonetimStokTakip.WebUI.Models;
using UrunYonetimi.Entites;

namespace UrunYonetimStokTakip.WebUI.Areas.Admin.Controllers
{
    public class UrunsController : Controller
    {
        private ModelDb db = new ModelDb();

        // GET: Admin/Uruns
        public ActionResult Index()
        {
            var urunler = db.Urunler.Include(u => u.Kategori).Include(u => u.Marka);
            return View(urunler.ToList());
        }

        // GET: Admin/Uruns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Urun urun = db.Urunler.Find(id);
            if (urun == null)
            {
                return HttpNotFound();
            }
            return View(urun);
        }

        // GET: Admin/Uruns/Create
        public ActionResult Create()
        {
            ViewBag.KategoriId = new SelectList(db.Kategoriler, "id", "KategoriAdi");
            ViewBag.MarkaId = new SelectList(db.Markalar, "id", "MarkaAdi");
            return View();
        }

        // POST: Admin/Uruns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,KategoriId,MarkaId,UrunAdi,Aciklama,EklenmeTarihi,AktifMi,UrunFiyati,Kdv,StokMiktari,ToptanFiyat")] Urun urun)
        {
            if (ModelState.IsValid)
            {
                db.Urunler.Add(urun);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.KategoriId = new SelectList(db.Kategoriler, "id", "KategoriAdi", urun.KategoriId);
            ViewBag.MarkaId = new SelectList(db.Markalar, "id", "MarkaAdi", urun.MarkaId);
            return View(urun);
        }

        // GET: Admin/Uruns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Urun urun = db.Urunler.Find(id);
            if (urun == null)
            {
                return HttpNotFound();
            }
            ViewBag.KategoriId = new SelectList(db.Kategoriler, "id", "KategoriAdi", urun.KategoriId);
            ViewBag.MarkaId = new SelectList(db.Markalar, "id", "MarkaAdi", urun.MarkaId);
            return View(urun);
        }

        // POST: Admin/Uruns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,KategoriId,MarkaId,UrunAdi,Aciklama,EklenmeTarihi,AktifMi,UrunFiyati,Kdv,StokMiktari,ToptanFiyat")] Urun urun)
        {
            if (ModelState.IsValid)
            {
                db.Entry(urun).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.KategoriId = new SelectList(db.Kategoriler, "id", "KategoriAdi", urun.KategoriId);
            ViewBag.MarkaId = new SelectList(db.Markalar, "id", "MarkaAdi", urun.MarkaId);
            return View(urun);
        }

        // GET: Admin/Uruns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Urun urun = db.Urunler.Find(id);
            if (urun == null)
            {
                return HttpNotFound();
            }
            return View(urun);
        }

        // POST: Admin/Uruns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Urun urun = db.Urunler.Find(id);
            db.Urunler.Remove(urun);
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
