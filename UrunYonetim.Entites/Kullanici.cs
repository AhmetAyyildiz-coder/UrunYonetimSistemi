﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunYonetimi.Entites;

namespace UrunYonetim.Entites
{
    public class Kullanici : IEntity
    {
        [Key() , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string Email { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public bool AktifMi { get; set; }
    }
}