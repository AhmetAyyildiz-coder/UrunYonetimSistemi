using System;
using System.Web.Mvc;
using UrunYonetim.BuisnessLayer;
using UrunYonetimi.Entites;

namespace UrunYonetimStokTakip.WebUI.Areas.Admin.Controllers
{
    public class MarkaController : Controller
    {
        MarkaManager manager = new MarkaManager();

        // GET: Admin/Marka
        public ActionResult Index()
        {
            //adım 1 ana index view' kısmını olustur ve datalarımızı buisness'dan cekip
            //burada basıyoruz list halinde.
            //buranın view kısmı hazır template'den list olanı kullanarak olusturuyoruz bu sebeble
            //ve data türü olarak marka sınıfımızı veriyoruz

            try
            {
                var listData = manager.GetAll();
                if (listData.Count > 0)
                {
                    //data bulunmustur. 
                    return View(listData);
                }
            }
            catch (System.Exception ex)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.NoContent);

            }

            return View();
        } //passed

        // GET: Admin/Marka/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Marka/Create
        [HttpPost]
        public ActionResult Create(Marka m)
        {
            try
            {
                m.EklenmeTarihi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                m.AktifMi = true;
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {

                    var sonuc = manager.Add(m);
                    if (sonuc == 1)
                    {
                        return RedirectToAction("Index");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Kayit Eklenilemedi");
                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Hata Olustu.  Kayit Eklenilemedi => " + " " + ex.Message);

            }

            return View();

        } //hersey tamam ama bos kayıt eklemesini kontrol etmek lazım.

        // GET: Admin/Marka/Edit/5
        public ActionResult Edit(int? id)
        {
            Marka tempM = new Marka();


            if (!id.HasValue)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            }
            else
            {
                try
                {
                    tempM = manager.getById(id.Value);
                    if (tempM == null)
                    {
                        return HttpNotFound();
                        //db den gelen data null ise bulunamadı hatası dondur
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Hata olustu ! , Veritabanına baglanılamadı , Hata kodu => " + " " + $"{ ex.Message}");

                }
            }



            return View(tempM);
        }

        // POST: Admin/Marka/Edit/5
        [HttpPost]
        public ActionResult Edit(Marka M)
        {


            // TODO: Add update logic here

            if (ModelState.IsValid)
            {

                try
                {
                    var sonuc = manager.Update(M);
                    if (sonuc == 1)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Kayıt Eklenilemedi !");
                    }
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError("", "Hata Olustu ! Kayıt Guncellenilemedi !" + $"{ex.Message}");

                }
            }
            return View();



        }

        // GET: Admin/Marka/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id.Value == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            }
            Marka tempData = manager.getById(id.Value);
            return View(tempData);
        }

        // POST: Admin/Marka/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            // TODO: Add delete logic here
            try
            {
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