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
using BuisnessLayer;
using UrunYonetim.BuisnessLayer;

namespace UrunYonetimStokTakip.WebUI.Areas.Admin.Controllers
{
    public class UrunsController : Controller
    {
        private ModelDb db = new ModelDb();
        UrunManager Umanager = new UrunManager();
        MarkaManager Mmanager = new MarkaManager();
        KategoriManager Kmanager = new KategoriManager();
        // GET: Admin/Uruns
        public ActionResult Index()
        {
            //var urunler = db.Urunler.Include(u => u.Kategori).Include(u => u.Marka);
            var urunler = Umanager.GetAll();
            return View(urunler);
        }

        // GET: Admin/Uruns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Urun urun = Umanager.Find(i => i.id == id.Value);
            if (urun == null)
            {
                return HttpNotFound();
            }
            return View(urun);
        }

        // GET: Admin/Uruns/Create
        public ActionResult Create()
        {
            ViewBag.KategoriId = new SelectList(Kmanager.GetAll(), "id", "KategoriAdi");
            ViewBag.MarkaId = new SelectList(Mmanager.GetAll(), "id", "MarkaAdi");
            return View();
        }

        // POST: Admin/Uruns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Urun urun)
        {
            if (ModelState.IsValid)
            {
                //db.Urunler.Add(urun);
                //db.SaveChanges();
                Umanager.Add(urun);
                return RedirectToAction("Index");
            }

            ViewBag.KategoriId = new SelectList(Kmanager.GetAll(), "id", "KategoriAdi", urun.KategoriId);
            ViewBag.MarkaId = new SelectList(Mmanager.GetAll(), "id", "MarkaAdi", urun.MarkaId);
            return View(urun);
        }

        // GET: Admin/Uruns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Urun urun = Umanager.Find(i => i.id == id.Value);
            if (urun == null)
            {
                return HttpNotFound();
            }
            ViewBag.KategoriId = new SelectList(Kmanager.GetAll(), "id", "KategoriAdi", urun.KategoriId);
            ViewBag.MarkaId = new SelectList(Mmanager.GetAll(), "id", "MarkaAdi", urun.MarkaId);
            return View(urun);
        }

        // POST: Admin/Uruns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,KategoriId,MarkaId,UrunAdi,Aciklama,EklenmeTarihi,AktifMi,UrunFiyati,Kdv,StokMiktari,ToptanFiyat")] Urun urun)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(urun).State = EntityState.Modified;
                //db.SaveChanges();
                Umanager.Update(urun);
                return RedirectToAction("Index");
            }
            ViewBag.KategoriId = new SelectList(Kmanager.GetAll(), "id", "KategoriAdi", urun.KategoriId);
            ViewBag.MarkaId = new SelectList(Mmanager.GetAll(), "id", "MarkaAdi", urun.MarkaId);
            return View(urun);
        }

        // GET: Admin/Uruns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Urun urun = Umanager.Find(i => i.id == id.Value);
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
            Urun urun = Umanager.Find(i => i.id == id);
            Umanager.Delete(id);

            return RedirectToAction("Index");
        }


    }
}
