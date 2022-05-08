using BuisnessLayer;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using UrunYonetimi.Entites;

namespace UrunYonetimStokTakip.WebUI.Areas.Admin.Controllers
{
    public class KategoriController : Controller
    {
        KategoriManager manager = new KategoriManager();
        // GET: Admin/Kategori
        public ActionResult Index()
        {
            IEnumerable<Kategori> kategoriler = manager.GetAll();
            return View(kategoriler);
        }
        // GET: Admin/Kategori/Delete/id?
        public ActionResult Delete(int? id)
        {

            var tempData = manager.Find(i => i.id == id.Value);
            return View(tempData);
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            else
            {
                int sonuc = manager.Delete(id);
                if (sonuc == 1)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }
        // GET: Admin/Kategori/Create/

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Kategori kategori)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    kategori.EklenmeTarihi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    var sonuc = manager.Add(kategori);
                    if (sonuc == 1)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Kayıt Eklenemedi !");
                    }
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError("", "Hata Olustu ! Kayıt Eklenemedi !" + $"{ex.Message}");
                }

            }

            return View();
        }

        // GET: Admin/Kategori/Edit/id?
        public ActionResult Edit(int? id)
        {
            Kategori tempKategori = new Kategori();
            if (tempKategori == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            else
            {
                try
                {
                    tempKategori = manager.Get(id.Value);
                    if (tempKategori == null)
                    {
                        return HttpNotFound();
                    }

                }
                catch (Exception ex)
                {

                    ModelState.AddModelError("", "Hata Olustu ! Kayıt Eklenemedi !" + $"{ex.Message}");

                }


            }
            return View(tempKategori);
        }
        [HttpPost]
        public ActionResult Edit(Kategori kategori)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var sonuc = manager.Update(kategori);
                    if (sonuc == 1)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Kayıt Eklenemedi !");
                    }
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError("", "Hata Olustu ! Kayıt Guncellenilemedi !" + $"{ex.Message}");
                }
            }
            return View();
        }
    }
}