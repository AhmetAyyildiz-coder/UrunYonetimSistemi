using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunYonetimi.Entites;

namespace UrunYonetimSistemiFrontEnt
{
    public partial class KategoriYonetimi : Form
    {
        BuisnessLayer.KategoriManager manager = new BuisnessLayer.KategoriManager();

        public KategoriYonetimi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            lblEklenmeTarihi.Text = DateTime.Now.ToShortDateString();
            GridDoldur();
            lblId.Text = "0";
        }

        void GridDoldur()
        {
            dtwKategoriler.DataSource = manager.GetAll();
            dtwKategoriler.Columns[0].Visible = false;
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxKategoriAdi.Text) && string.IsNullOrWhiteSpace(rTxtBoxKategoriAciklama.Text))
            {
                MessageBox.Show("Lütfen gerekli Alanları doldurunuz");
                Thread.Sleep(500);
                label1.Text = "* Kategori Adı";
                label2.Text = "* Aciklama";
               

            }
            else
            {
                try
                {
                    int sonuc = manager.Add(new Kategori
                    {
                        Aciklama = rTxtBoxKategoriAciklama.Text,
                       EklenmeTarihi = Convert.ToDateTime(lblEklenmeTarihi.Text), AktifMi = chBoxKategoriAktif.Checked
                       , KategoriAdi = txtboxKategoriAdi.Text
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
                catch (Exception)
                {

                    throw;
                }
            }

        }

        void TxtBoxTemizle()
        {
            foreach (Control item in this.grpBoxKategoriYonetim.Controls)
            {

                lblId.Text = "0";
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

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            if (lblId.Text != "0")
            {
                try
                {
                    sonuc = manager.Update(new Kategori
                    {
                        Aciklama = rTxtBoxKategoriAciklama.Text,
                        EklenmeTarihi = Convert.ToDateTime(lblEklenmeTarihi.Text),
                        AktifMi = chBoxKategoriAktif.Checked
                       ,
                        KategoriAdi = txtboxKategoriAdi.Text,
                        id = int.Parse(lblId.Text)
                    });

                    if (sonuc == 1)
                    {
                        DialogResult result = MessageBox.Show("Kayıt basarili sekilde guncellenildi");
                        if (result == DialogResult.OK)
                        {
                            Thread.Sleep(1000);
                            TxtBoxTemizle();
                            GridDoldur();
                        }



                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Lutfen Guncellenicek Kaydı Seciniz");
            }
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            if (lblId.Text != "0")
            {
                try
                {
                    int sonuc = manager.Delete(int.Parse(lblId.Text));
                    if (sonuc == 1)
                    {
                        DialogResult result = MessageBox.Show("Tebrikler kayit basarili sekilde silindi", "Basarili !");

                        if (result == DialogResult.OK)
                        {
                            Thread.Sleep(500);
                            TxtBoxTemizle();
                            GridDoldur();
                        }

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Silmek için bir kayıt seçiniz");
            }
        }

        private void dtwKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dtwKategoriler.CurrentRow.Cells[0].Value.ToString();
            txtboxKategoriAdi.Text = dtwKategoriler.CurrentRow.Cells[1].Value.ToString();
            rTxtBoxKategoriAciklama.Text = dtwKategoriler.CurrentRow.Cells[2].Value.ToString();
            lblEklenmeTarihi.Text = dtwKategoriler.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
