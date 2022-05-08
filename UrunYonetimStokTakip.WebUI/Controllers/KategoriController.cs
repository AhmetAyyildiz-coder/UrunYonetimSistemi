using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuisnessLayer;
using UrunYonetim.Entites;


namespace UrunYonetimStokTakip.WebUI.Controllers
{
    public class KategoriController : Controller
    {
        KategoriManager manager = new KategoriManager();

        // GET: Kategori
        public ActionResult Index()
        {
            
            return View();
        }
    }
}