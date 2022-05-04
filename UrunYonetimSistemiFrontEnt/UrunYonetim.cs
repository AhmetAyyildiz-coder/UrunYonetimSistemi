using BuisnessLayer;
using System;
using System.Windows.Forms;
using UrunYonetimi.Entites;
namespace UrunYonetimSistemiFrontEnt
{
    public partial class UrunYonetim : Form
    {
        public UrunYonetim()
        {
            InitializeComponent();
        }
        UrunManager mananger = new UrunManager();

        private void grpBoxKategoriYonetim_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            mananger.Add(new Urun
            {
                UrunAdi = txtBoxUrunAdi.Text 
            });
        }
    }
}
