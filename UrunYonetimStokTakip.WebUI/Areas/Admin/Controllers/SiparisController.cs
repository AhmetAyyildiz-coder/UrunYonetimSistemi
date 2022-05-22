using BuisnessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UrunYonetim.Entites;
using UrunYonetimStokTakip.WebUI.Models;

namespace UrunYonetimStokTakip.WebUI.Areas.Admin.Controllers
{
    public class SiparisController : Controller
    {
        SiparisManager Smanager = new SiparisManager();
        MusteriManager Mmanager = new MusteriManager();
        UrunManager Umanager = new UrunManager();
        // GET: Admin/Siparis
        public ActionResult Index()
        {
            //var siparisler = db.Siparisler.Include(s => s.Musteri).Include(s => s.Urun);
            
            return View(Smanager.GetAll());
        }

        // GET: Admin/Siparis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Siparis siparis = Smanager.Find(i => i.id == id);
            if (siparis == null)
            {
                return HttpNotFound();
            }
            return View(siparis);
        }

        // GET: Admin/Siparis/Create
        public ActionResult Create()
        {
            ViewBag.MusteriId = new SelectList(Mmanager.GetAll(), "id", "Ad");
            ViewBag.UrunId = new SelectList(Umanager.GetAll(), "id", "UrunAdi");
            return View();
        }

        // POST: Admin/Siparis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,SiparisNo,MusteriId,SiparisTarihi,UrunId")] Siparis siparis)
        {
            if (ModelState.IsValid)
            {
                //db.Siparisler.Add(siparis);
                //db.SaveChanges();
                Smanager.Add(siparis);
                return RedirectToAction("Index");
            }

            //ViewBag.MusteriId = new SelectList(db.Musteriler, "id", "Ad", siparis.MusteriId);
            //ViewBag.UrunId = new SelectList(db.Urunler, "id", "UrunAdi", siparis.UrunId);
            ViewBag.MusteriId = new SelectList(Mmanager.GetAll(), "id", "Ad", siparis.MusteriId);
            ViewBag.UrunId = new SelectList(Umanager.GetAll(), "id", "UrunAdi", siparis.UrunId);
            return View(siparis);
        }

        // GET: Admin/Siparis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Siparis siparis = Smanager.Find(i=> i.id == id.Value);
            if (siparis == null)
            {
                return HttpNotFound();
            }
            //ViewBag.MusteriId = new SelectList(db.Musteriler, "id", "Ad", siparis.MusteriId);
            //ViewBag.UrunId = new SelectList(db.Urunler, "id", "UrunAdi", siparis.UrunId);
            ViewBag.MusteriId = new SelectList(Mmanager.GetAll(), "id", "Ad", siparis.MusteriId);
            ViewBag.UrunId = new SelectList(Umanager.GetAll(), "id", "UrunAdi", siparis.UrunId);
            return View(siparis);
        }

        // POST: Admin/Siparis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Siparis siparis)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(siparis).State = EntityState.Modified;
                //db.SaveChanges();
                Smanager.Update(siparis);
                return RedirectToAction("Index");
            }
            ViewBag.MusteriId = new SelectList(Mmanager.GetAll(), "id", "Ad", siparis.MusteriId);
            ViewBag.UrunId = new SelectList(Umanager.GetAll(), "id", "UrunAdi", siparis.UrunId);
            return View(siparis);
        }

        // GET: Admin/Siparis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Siparis siparis = db.Siparisler.Find(id);
            Siparis siparis = Smanager.Find(i=> i.id == id.Value);
            if (siparis == null)
            {
                return HttpNotFound();
            }
            return View(siparis);
        }

        // POST: Admin/Siparis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Siparis siparis = db.Siparisler.Find(id);
            //db.Siparisler.Remove(siparis);
            //db.SaveChanges();
            Siparis siparis = Smanager.Find(i => i.id == id);
            Smanager.Delete(siparis.id);
            return RedirectToAction("Index");
        }

        
    }
}
