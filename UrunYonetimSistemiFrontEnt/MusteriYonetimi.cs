using BuisnessLayer;
using System;
using System.Threading;
using System.Windows.Forms;
using UrunYonetim.Entites;

namespace UrunYonetimSistemiFrontEnt
{
    public partial class MusteriYonetimi : Form
    {
        public MusteriYonetimi()
        {
            InitializeComponent();
        }
        MusteriManager manager = new MusteriManager();
        private void MusteriYonetimi_Load(object sender, System.EventArgs e)
        {
            Yukle();
            dgwMusteriYonetim.Columns[0].Visible = false;
            lblMusteriEklenmeTarihi.Text = DateTime.Now.ToShortDateString();
            lblId.Text = "0";
        }
        void Yukle()
        {
            dgwMusteriYonetim.DataSource = manager.GetAll();
        }

        private void grpBoxMusteriBilgileri_Enter(object sender, System.EventArgs e)
        {

        }

        private void Temizle()
        {
            foreach (Control item in grpBoxMusteriBilgileri.Controls)
            {
                if (item is TextBox || item is RichTextBox)
                {
                    item.Text = string.Empty;
                }
                checkBox1.Checked = false;
                lblId.Text = "0";
            }
        }

        private void btnMusteriEkle_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxMusteriAdi.Text) || !string.IsNullOrEmpty(txtBoxMusteriSoyadi.Text))
            {
                try
                {
                    var sonuc = manager.Add(new Musteri
                    {
                        id = Convert.ToInt32(lblId.Text),
                        Ad = txtBoxMusteriAdi.Text,
                        Adres = richTextBoxMusteriAdres.Text,
                        Email = txtBoxMusteriEmail.Text,
                        Soyad = txtBoxMusteriSoyadi.Text,
                        Telefon = textBoxMusteriTelefon
                    .Text,
                        EklenmeTarihi = DateTime.Parse(lblMusteriEklenmeTarihi.Text)
                    });

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Musteri Ekleme Basarili");

                        Thread.Sleep(1000);
                        Temizle();
                        Yukle();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Kullanici Adi ve soyadi bos bırakılmamalıdır.");
            }

        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxMusteriAdi.Text) || !string.IsNullOrEmpty(txtBoxMusteriSoyadi.Text))
            {
                if (lblId.Text != "0")
                {
                    try
                    {

                        var sonuc = manager.Update(new Musteri
                        {
                            id = int.Parse(lblId.Text),

                            Ad = txtBoxMusteriAdi.Text,
                            Adres = richTextBoxMusteriAdres.Text,
                            Email = txtBoxMusteriEmail.Text,
                            Soyad = txtBoxMusteriSoyadi.Text,
                            Telefon = textBoxMusteriTelefon
                        .Text,
                            EklenmeTarihi = DateTime.Parse(lblMusteriEklenmeTarihi.Text),
                            AktifMi = checkBox1.Checked
                        });

                        if (sonuc > 0)
                        {
                            MessageBox.Show("Musteri Guncelleme Basarili");

                            Thread.Sleep(500);
                            Temizle();
                            Yukle();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }

            }
            else
            {
                MessageBox.Show("Kullanici Adi ve soyadi bos bırakılmamalıdır.");
            }
        }

        private void dgwMusteriYonetim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgwMusteriYonetim.CurrentRow.Cells[0].Value.ToString();
            txtBoxMusteriAdi.Text = dgwMusteriYonetim.CurrentRow.Cells[1].Value.ToString();
            txtBoxMusteriSoyadi.Text = dgwMusteriYonetim.CurrentRow.Cells[2].Value.ToString();
            txtBoxMusteriEmail.Text = dgwMusteriYonetim.CurrentRow.Cells[3].Value.ToString();
            textBoxMusteriTelefon.Text = dgwMusteriYonetim.CurrentRow.Cells[4].Value.ToString();
            richTextBoxMusteriAdres.Text = dgwMusteriYonetim.CurrentRow.Cells[5].Value.ToString();
            lblMusteriEklenmeTarihi.Text = dgwMusteriYonetim.CurrentRow.Cells[6].Value.ToString();
            checkBox1.Checked = Convert.ToBoolean(dgwMusteriYonetim.CurrentRow.Cells[7].Value);
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text == "0")
                {
                    MessageBox.Show("Lutfen silinecek kaydı seçiniz");
                }
                else
                {
                    int sonuc = manager.Delete(int.Parse(lblId.Text));

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Musteri Silme Basarili");
                        Thread.Sleep(500);
                        Temizle();
                        Yukle();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
