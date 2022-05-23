using BuisnessLayer;
using System;
using System.Web.Mvc;
using UrunYonetim.Entites;

namespace UrunYonetimStokTakip.WebUI.Areas.Admin.Controllers
{
    public class KullaniciController : Controller
    {
        //Butun db islemlerimizi yapıcak olan sınıfımız
        KullaniciManager manager = new KullaniciManager();

        // GET: Admin/Kullanici
        public ActionResult Index()
        {
            var listKullanici = manager.GetAll();
            return View(listKullanici);
        }


        // GET: Admin/Kullanici/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Admin/Kullanici/Create
        [HttpPost]
        public ActionResult Create(Kullanici k)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    //eger model doğrulanması yapılmıs ise işleme basla.
                    var sonuc = manager.Add(k);
                    if (sonuc == 1)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Kayit Eklenilemedi");
                    }
                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Hata Olustu.  Kayit Eklenilemedi => " + " " + ex.Message);

            }
            return View();
        }

        // GET: Admin/Kullanici/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            //eger index'den gelen id bos değilse bu datayı db den cek. kullanici nesnesi halinde
            Kullanici tempKullanici = manager.getById(id.Value);
            if (tempKullanici == null)
            {
                return HttpNotFound();
            }
            return View(tempKullanici);
        }

        // POST: Admin/Kullanici/Edit/5
        [HttpPost]
        public ActionResult Edit(Kullanici k)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    var sonuc = manager.Update(k);
                    return RedirectToAction("Index");

                }
                return View(k);

            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Kullanici/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            }
            Kullanici tempData = manager.getById(id.Value);
            return View(tempData);
        }

        // POST: Admin/Kullanici/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                if (ModelState.IsValid)
                {
                    var sonuc = manager.Delete(id);
                    if (sonuc == 1)
                    {
                        return RedirectToAction("Index");

                    }
                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Bir hata olustu => " + $"{ex.Message} ");

            }
            return View();
        }
    }
}
