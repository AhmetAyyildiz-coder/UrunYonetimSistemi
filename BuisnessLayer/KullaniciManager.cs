using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using UrunYonetim.DataAccess;
using UrunYonetim.Entites;

namespace BuisnessLayer
{
    /// <summary>
    /// Bu sınıf bizim kullanicilar hakkında crud islemler yapmamıza olanak sağlayan , DataAcces ile bağlantısı olan
    /// sınıftır.
    /// </summary>
    public class KullaniciManager
    {
        ModelDb _context;

        public KullaniciManager()
        {
            _context = new ModelDb();
        }

        /// <summary>
        /// Database'deki bütün kullanicilari - kullanici nesnesi - liste halidne bize döndürür.
        /// </summary>
        /// <returns></returns>
        public List<Kullanici> kullanicilar()
        {
            return _context.Kullanicilar.ToList();
        }

        /// <summary>
        /// Eger sonuc 10 donerse database'de bu kullanici kayitlidir. Eger sonuc 1 donerse kullanici
        /// db'de kayitli değildir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int KullaniciKontrol(int id)
        {
            int sonuc = 1;
            var temp = _context.Kullanicilar.ToList().FindAll(i => i.id == id);
            if (temp.Count > 0)
            {
                sonuc = 10;
            }
            return sonuc;
        }

        /// <summary>
        /// ekleme islemi basarılı ise return 1 , değil ise return 0 doner
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public int Add(Kullanici k)
        {

            _context.Kullanicilar.Add(k);
            return _context.SaveChanges();

        }


        public int Update(Kullanici k)
        {
            _context.Kullanicilar.AddOrUpdate(k);
            return _context.SaveChanges();
        }

        /// <summary>
        /// İd parametresine göre kullaniciyi bulmamızı sağlayan ve bulunan
        /// kullaniciyi bize donduren metot.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Kullanici getById(int id)
        {
            Kullanici temp = _context.Kullanicilar.Find(id);
            return temp;
        }

        public int Delete(int id)
        {
            _context.Kullanicilar.Remove(getById(id));
            return _context.SaveChanges();
        }

        public Kullanici Find(string kullaniciadi , string sifre)
        {
            return _context.Kullanicilar.Where(i => i.kullaniciAdi == kullaniciadi || i.sifre == sifre).FirstOrDefault();
        }
    }
}
