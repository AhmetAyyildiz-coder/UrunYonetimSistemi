using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
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

        }

        /// <summary>
        /// DB'den bütün markaları bize liste halinde döndüren metot.
        /// </summary>
        /// <returns></returns>
        public List<Marka> GetAll()
        {
            return _context.Markalar.ToList();
        }
    }
}
