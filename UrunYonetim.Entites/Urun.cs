﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunYonetimi.Entites
{
    public class Urun : IEntity
    {
        [Key(), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        //foreign key kategori 
        public int KategoriId { get; set; }
        //foreign key Marka 
        public int MarkaId { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public bool AktifMi { get; set; }
        public decimal UrunFiyati { get; set; }
        public int Kdv { get; set; }
        public int StokMiktari { get; set; }
        public decimal ToptanFiyat { get; set; }
        public override string ToString()
        {
            return UrunAdi;
        }

        public virtual Kategori Kategori { get; set; }
        public virtual Marka Marka { get; set; }

    }


}
