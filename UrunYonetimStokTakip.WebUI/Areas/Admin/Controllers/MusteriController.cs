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
    public class MusteriController : Controller
    {
        private MusteriManager manager = new MusteriManager();

        // GET: Admin/Musteri
        public ActionResult Index()
        {
            return View(manager.GetAll());
        }


        // GET: Admin/Musteri/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musteri musteri = manager.Find(i => i.id == id.Value);
            if (musteri == null)
            {
                return HttpNotFound();
            }
            return View(musteri);
        }

        // GET: Admin/Musteri/Create
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                musteri.EklenmeTarihi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                musteri.AktifMi = true;
                manager.Add(musteri);

                return RedirectToAction("Index");
            }

            return View(musteri);
        }

        // GET: Admin/Musteri/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Musteri musteri)
        {
            if (ModelState.IsValid)
            {
                var sonuc = manager.Update(musteri);
                return RedirectToAction("Index");
            }
            return View(musteri);
        }


        

        // GET: Admin/Musteri/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Musteri musteri = manager.Find(i => i.id == id);
            if (musteri == null)
            {
                return HttpNotFound();
            }
            return View(musteri);
        }

        // POST: Admin/Musteri/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Musteri musteri = manager.Find(i => i.id == id);
            manager.Delete(musteri.id);
            return RedirectToAction("Index");
        }
      
    }
}
