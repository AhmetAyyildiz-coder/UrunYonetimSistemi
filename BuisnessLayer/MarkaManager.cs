using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using UrunYonetim.DataAccess;
using UrunYonetimi.Entites;

namespace UrunYonetim.BuisnessLayer
{

    /// <summary>
    /// Bu sınıfımız Marka Sınıfının Crud islemlerini devralıcak. Gerekli dönüştürme gibi işlemleri yapıcak
    /// </summary>
    public class MarkaManager
    {
        ModelDb _context;

        public MarkaManager()
        {
            _context = new ModelDb();
            _context.Set<Marka>();
        }

        /// <summary>
        /// DB'den bütün markaları bize liste halinde döndüren metot.
        /// </summary>
        /// <returns></returns>
        public List<Marka> GetAll()
        {

            return _context.Markalar.ToList();
        }

        //marka eklemeden önce aynı markayı tekrar eklememesi için id kontrolü yapılmalı
        /// <summary>
        /// Eger sonuc 10 donerse bu kayıt daha once database'de var. Listede iki kez kayıta tıklamış.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int MarkaKontrol(int id)
        {
            int sonuc = 1;
            var temp = _context.Markalar.ToList().FindAll(i => i.id == id).ToList();
            if (temp.Count > 0)
            {
                sonuc = 10;
            }
            return sonuc;
        }
        public int Add(Marka m)
        {
            int sonuc = 0;

            _context.Markalar.Add(m);
            sonuc = _context.SaveChanges();
            return sonuc;
        }

        public Marka getById(int id)
        {
            Marka temp = _context.Markalar.Find(id);
            return temp;
        }

        //update islemlerinde modern olarak böyle bir kısayol kullanabiliyoruz.
        public int Update(Marka M)
        {
            _context.Markalar.AddOrUpdate(M);
            return _context.SaveChanges();
        }

        public int Delete(int id)
        {
            _context.Markalar.Remove(getById(id));
            return _context.SaveChanges();
        }
    }
}
