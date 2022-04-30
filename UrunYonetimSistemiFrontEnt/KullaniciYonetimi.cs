using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunYonetim.Entites;


namespace UrunYonetimSistemiFrontEnt
{
    public partial class KullaniciYonetimi : Form
    {
        BuisnessLayer.KullaniciManager kullaniciManager = new BuisnessLayer.KullaniciManager();
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }

        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {

        }

        void GridDoldur()
        {
            dgwUrunYonetimi.DataSource = kullaniciManager.kullanicilar();
            dgwUrunYonetimi.Columns[0].Visible = false;
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            int sonuc =kullaniciManager.Add(new Kullanici
            {
                Ad = txtBoxAdi.Text,
                Email = txtBoxEmail.Text,
                AktifMi = checkBox1.Checked,
                kullaniciAdi
            = txtBoxKullaniciAdi.Text,
                sifre = txtBoxSifre.Text,
                Soyad = txtBoxSoyadi.Text
                
            });

            if (sonuc == 1)
            {
                DialogResult result = MessageBox.Show("Kayit Ekleme İslemi Basarili");
                if (result == DialogResult.OK)
                {
                    GridDoldur(); TxtBoxTemizle();
                }
            }
        }

        void TxtBoxTemizle()
        {
            foreach (Control item in this.grpBoxKullaniciBilgileri.Controls)
            {


                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                if (item is RichTextBox)
                {
                    item.Text = string.Empty;
                }
                if (item is CheckBox)
                {
                    (item as CheckBox).Checked = false;

                }
                

            }

        }

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnKullaniciSil_Click(object sender, EventArgs e)
        {

        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
