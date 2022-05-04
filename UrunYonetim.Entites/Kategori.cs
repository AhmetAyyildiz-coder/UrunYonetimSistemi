using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunYonetimi.Entites
{
    public class Kategori : IEntity
    {
        [Key(), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public bool AktifMi { get; set; }
        public override string ToString()
        {
            return KategoriAdi;
        }
    }
}
