using System;
using System.Threading;
using System.Windows.Forms;
using UrunYonetim.Entites;


namespace UrunYonetimSistemiFrontEnt
{
    public partial class KullaniciYonetimi : Form
    {
        BuisnessLayer.KullaniciManager manager = new BuisnessLayer.KullaniciManager();
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }

        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            lblEklenmeTarihi.Text = DateTime.Now.ToShortDateString();
            GridDoldur();
            lblId.Text = "0";
        }

        void GridDoldur()
        {
            dgwUrunYonetimi.DataSource = manager.kullanicilar();
            dgwUrunYonetimi.Columns[0].Visible = false;
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxKullaniciAdi.Text) && string.IsNullOrWhiteSpace(txtBoxSifre.Text) && string.IsNullOrWhiteSpace(txtBoxAdi.Text))
            {
                MessageBox.Show("Lütfen gerekli Alanları doldurunuz");
                Thread.Sleep(500);
                lblAdi.Text = "* Ad";
                lblEmail.Text = "* Email";
                lblSifre.Text = "* Sifre";
                lblKullaniciAdi.Text = "* Kullanici Adi";

            }
            else
            {
                try
                {
                    int sonuc = manager.Add(new Kullanici
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
                catch (Exception)
                {

                    throw;
                }
            }


        }

        void TxtBoxTemizle()
        {
            foreach (Control item in this.grpBoxKullaniciBilgileri.Controls)
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

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            if (lblId.Text!="0")
            {
                try
                {
                    sonuc = manager.Update(new Kullanici
                    {
                        Ad = txtBoxAdi.Text,
                        Soyad = txtBoxSoyadi.Text,
                        AktifMi = checkBox1.Checked,
                        Email = txtBoxEmail.Text,
                        kullaniciAdi = txtBoxKullaniciAdi.Text,
                        sifre =
                 txtBoxSifre.Text,
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

        private void btnKullaniciSil_Click(object sender, EventArgs e)
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

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgwUrunYonetimi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgwUrunYonetimi.CurrentRow.Cells[0].Value.ToString();
            txtBoxKullaniciAdi.Text = dgwUrunYonetimi.CurrentRow.Cells[1].Value.ToString();
            txtBoxSifre.Text = dgwUrunYonetimi.CurrentRow.Cells[2].Value.ToString();
            txtBoxEmail.Text = dgwUrunYonetimi.CurrentRow.Cells[3].Value.ToString();
            txtBoxAdi.Text = dgwUrunYonetimi.CurrentRow.Cells[4].Value.ToString();
            txtBoxSoyadi.Text = dgwUrunYonetimi.CurrentRow.Cells[5].Value.ToString();
            checkBox1.Checked = Convert.ToBoolean(dgwUrunYonetimi.CurrentRow.Cells[6].Value);
        }
    }
}
