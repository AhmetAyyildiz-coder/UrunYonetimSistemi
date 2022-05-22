using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunYonetimSistemiFrontEnt
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnKategoriYonetimi_Click(object sender, EventArgs e)
        {
            KategoriYonetimi kategoriYonetimi = new KategoriYonetimi(); 
            kategoriYonetimi.ShowDialog();

        }

        private void btnKullaniciYonetimi_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi =new KullaniciYonetimi();
            kullaniciYonetimi.ShowDialog();

        }

        private void btnMarkaYoentimi_Click(object sender, EventArgs e)
        {
            MarkaYonetimi markaYonetimi = new MarkaYonetimi();
            markaYonetimi.ShowDialog();
        }

        private void btnUrunYonetimi_Click(object sender, EventArgs e)
        {
            UrunYonetim urunYonetim = new UrunYonetim();
            urunYonetim.ShowDialog();
        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            MusteriYonetimi musteriYonetimi = new MusteriYonetimi();
            musteriYonetimi.ShowDialog();

        }

        private void btnSiparisYonetimi_Click(object sender, EventArgs e)
        {
            SiparisYonetimi siparisYonetimi = new SiparisYonetimi();    
            siparisYonetimi.ShowDialog();
        }
    }
}
