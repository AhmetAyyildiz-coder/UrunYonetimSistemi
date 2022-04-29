﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunYonetimi.Entites
{
    public class Marka : IEntity
    {
        public int id { get; set; }
        public string MarkaAdi { get; set; }
        public string Aciklama { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public bool AktifMi { get; set; }
    }
}
