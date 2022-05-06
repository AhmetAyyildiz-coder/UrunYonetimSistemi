using BuisnessLayer;
using System;
using System.Threading;
using System.Windows.Forms;
using UrunYonetimi.Entites;

namespace UrunYonetimSistemiFrontEnt
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }
        KategoriManager manager = new KategoriManager();
        void Yukle()
        {
            dtwKategoriler.DataSource = manager.GetAll();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        void temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control item2 in item.Controls)
                    {
                        if (item2 is TextBox)
                        {
                            item2.Text = string.Empty;
                        }
                        if (item2 is RichTextBox)
                        {
                            item2.Text = string.Empty;
                        }
                    }
                    lblId.Text = "0";
                }
            }
        }
        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtboxKategoriAdi.Text) && string.IsNullOrWhiteSpace(rTxtBoxKategoriAciklama.Text))
            {
                MessageBox.Show("Gerekli Alanları doldurunuz");
                label1.Text = "* Kategori Adı";
                label2.Text = "* Aciklama";
            }
            else
            {
                try
                {
                    var sonuc = manager.Add(new Kategori()
                    {
                        Aciklama = rTxtBoxKategoriAciklama.Text,
                        AktifMi = chBoxKategoriAktif.Checked,
                        EklenmeTarihi = DateTime.Now,
                        KategoriAdi = txtboxKategoriAdi.Text
                    });

                    if (sonuc == 1)
                    {
                        DialogResult result = MessageBox.Show("Kayıt Eklenildi.");
                        if (result == DialogResult.OK)
                        {
                            Thread.Sleep(1000);
                            Yukle();
                            temizle();

                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Kayıt Eklenirken bir hata olustu . Hata Kodu =>" + ex.Message);
                }
            }
           

        }



        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
            this.dtwKategoriler.Columns[0].Visible = false;
            lblEklenmeTarihi.Text = DateTime.Now.ToString("MM/dd/yyyy");
            lblId.Text = "0";
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            //ilk olarak guncellenilecek verileri textbox'a doldururuz.
            //bunu datagridview cellclick event'i ile çözelim
            if (lblId.Text!="0")
            {
                try
                {
                    sonuc = manager.Update(new Kategori()
                    {
                        id = int.Parse(lblId.Text),
                        Aciklama = rTxtBoxKategoriAciklama.Text,
                        AktifMi = chBoxKategoriAktif.Checked,
                        EklenmeTarihi = Convert.ToDateTime(lblEklenmeTarihi.Text),
                        KategoriAdi = txtboxKategoriAdi.Text
                     });                 
                    if (sonuc == 1)
                    {
                        DialogResult result = MessageBox.Show("Kayıt Guncellenildi.");
                        if (result == DialogResult.OK)
                        {
                            Thread.Sleep(1000);
                            Yukle();
                            temizle();

                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Kayıt Eklenirken bir hata olustu!n\\Hata Kodu =>" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Guncellenicek Kaydı Seciniz");
            }


        }

        private void dtwKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtwKategoriler.CurrentRow.Cells[0].Value != null)
                {
                    lblId.Text = dtwKategoriler.CurrentRow.Cells[0].Value.ToString();

                }
                txtboxKategoriAdi.Text = dtwKategoriler.CurrentRow.Cells[1].Value.ToString();
                rTxtBoxKategoriAciklama.Text = dtwKategoriler.CurrentRow.Cells[2].Value.ToString();
                chBoxKategoriAktif.Checked = Convert.ToBoolean(dtwKategoriler.CurrentRow.Cells[4].Value);
                lblEklenmeTarihi.Text = dtwKategoriler.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Kayıt Alınırken hata alındı!n\\" + ex.Message, "Hata !", MessageBoxButtons.OKCancel);
            }
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            int sonuc = 0;
            if (lblId.Text !="0")
            {
                try
                {
                    sonuc = manager.Delete(int.Parse(lblId.Text));
                    if (sonuc == 1)
                    {
                        DialogResult dialog = MessageBox.Show("Kayıt Basarılı sekilde silindi");
                        if (dialog == DialogResult.OK)
                        {
                            Thread.Sleep(1000);
                            Yukle();
                            temizle();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata !", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Silinecek kaydı seciniz");
            }
            
        }
    }
}
