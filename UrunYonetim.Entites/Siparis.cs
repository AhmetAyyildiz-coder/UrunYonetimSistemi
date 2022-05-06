using System;
using UrunYonetimi.Entites;

namespace UrunYonetim.Entites
{
    public class Siparis : IEntity
    {
        public int id { get; set; }
        public string SiparisNo { get; set; }
        public int MusteriId { get; set; }

        public DateTime SiparisTarihi { get; set; }
        public int UrunId { get; set; }
    }
}
