using BuisnessLayer;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunYonetim.BuisnessLayer;
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
        KategoriManager kategoriManager = new KategoriManager();
        MarkaManager markaManager = new MarkaManager();
        void Yukle()
        {
            Thread.Sleep(1000);
            dgwUrunYonetimi.DataSource = mananger.GetAll();

        }
        private void grpBoxKategoriYonetim_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUrunFiyati.Text))
            {
                try
                {

                    int sonuc = mananger.Add(new Urun
                    {
                        UrunAdi = txtBoxUrunAdi.Text,
                        UrunFiyati = decimal.Parse(txtUrunFiyati.Text),
                        Aciklama = rTxtBoxUrunAciklama.Text,
                        AktifMi = chboxUrunAktif.Checked,
                        EklenmeTarihi = DateTime.Parse(lblEklenmeTarih.Text),
                        Kdv = int.Parse(txtKDV.Text),
                        StokMiktari = int.Parse(txtStokMiktari.Text),
                        ToptanFiyat = decimal.Parse(txtToptanFiyat.Text)
                        ,
                        KategoriId = int.Parse(comboBoxUrunKategori.SelectedValue.ToString()),
                        MarkaId = int.Parse(comboBoxUrunMarka.SelectedValue.ToString())
                    });

                    if (sonuc == 1)
                    {
                        MessageBox.Show("Kayit basarili");
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
                MessageBox.Show("Fiyat bilgisi girilmelidir !!");
            }


        }

        private void Temizle()
        {
            foreach (Control item in this.grpBoxKategoriYonetim.Controls)
            {
                if (item is TextBox || item is RichTextBox)
                {
                    item.Text = string.Empty;
                }
                chboxUrunAktif.Checked = false;
                lblId.Text = "0";
            }
        }

        private void UrunYonetim_Load(object sender, EventArgs e)
        {
            lblEklenmeTarih.Text = DateTime.Now.ToShortDateString();
            dgwUrunYonetimi.DataSource = mananger.GetAll();
            dgwUrunYonetimi.Columns[0].Visible = false;
            dgwUrunYonetimi.Columns[1].Visible = false;

            dgwUrunYonetimi.Columns[2].Visible = false;

            comboBoxUrunKategori.DataSource = kategoriManager.GetAll();
            comboBoxUrunMarka.DataSource = markaManager.GetAll();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                int sonuc = mananger.Update(new Urun
                {
                    id = int.Parse(lblId.Text),
                    UrunAdi = txtBoxUrunAdi.Text,
                    UrunFiyati = decimal.Parse(txtUrunFiyati.Text),
                    Aciklama = rTxtBoxUrunAciklama.Text,
                    AktifMi = chboxUrunAktif.Checked,
                    EklenmeTarihi = DateTime.Parse(lblEklenmeTarih.Text),
                    Kdv = int.Parse(txtKDV.Text),
                    StokMiktari = int.Parse(txtStokMiktari.Text),
                    ToptanFiyat = decimal.Parse(txtToptanFiyat.Text)
                    ,
                    KategoriId = int.Parse(comboBoxUrunKategori.SelectedValue.ToString()),
                    MarkaId = int.Parse(comboBoxUrunMarka.SelectedValue.ToString())
                });

                if (sonuc == 1)
                {
                    MessageBox.Show("Kayit Guncelleme Basarili");
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

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            int sonuc = 0;

            try
            {
                if (int.Parse(lblId.Text) > 0)
                {
                    sonuc = mananger.Delete(int.Parse(lblId.Text));
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Tebrikler Kayıt silme  basarilidir.");
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

        private void dgwUrunYonetimi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblId.Text = dgwUrunYonetimi.CurrentRow.Cells[0].Value.ToString();

            int urunID = Convert.ToInt32(lblId.Text);
            if (urunID > 0)
            {
                var urun = mananger.Get(urunID);
                if (urun != null)
                {
                    txtBoxUrunAdi.Text = urun.UrunAdi;
                    txtKDV.Text = urun.Kdv.ToString();
                    txtStokMiktari.Text = urun.StokMiktari.ToString();
                    txtToptanFiyat.Text = urun.ToptanFiyat.ToString();
                    txtUrunFiyati.Text = urun.UrunFiyati.ToString();
                    rTxtBoxUrunAciklama.Text = urun.Aciklama;
                    chboxUrunAktif.Checked = urun.AktifMi;
                    lblEklenmeTarih.Text = urun.EklenmeTarihi.ToShortDateString();
                    lblId.Text = urun.id.ToString();
                    comboBoxUrunKategori.SelectedValue = urun.KategoriId;
                    comboBoxUrunMarka.SelectedValue = urun.MarkaId;
                    txtToptanFiyat.Text = urun.ToptanFiyat.ToString();
                }
            }
            //txtBoxUrunAdi.Text = dgwUrunYonetimi.CurrentRow.Cells[3].Value.ToString();
            //rTxtBoxUrunAciklama.Text = dgwUrunYonetimi.CurrentRow.Cells[4].Value.ToString();
            //txtUrunFiyati.Text = dgwUrunYonetimi.CurrentRow.Cells[7].Value.ToString();
            //txtKDV.Text = dgwUrunYonetimi.CurrentRow.Cells[8].Value.ToString();
            //txtStokMiktari.Text = dgwUrunYonetimi.CurrentRow.Cells[9].Value.ToString();
            //comboBoxUrunKategori.SelectedIndex = int.Parse(dgwUrunYonetimi.CurrentRow.Cells[1].Value.ToString());
            //comboBoxUrunMarka.SelectedIndex = int.Parse(dgwUrunYonetimi.CurrentRow.Cells[2].Value.ToString())-1;
            //txtToptanFiyat.Text = dgwUrunYonetimi.CurrentRow.Cells[10].Value.ToString();
            //chboxUrunAktif.Checked = Convert.ToBoolean(dgwUrunYonetimi.CurrentRow.Cells[6].Value);
            //lblEklenmeTarih.Text = dgwUrunYonetimi.CurrentRow.Cells[5].Value.ToString();
            //lblId.Text = dgwUrunYonetimi.CurrentRow.Cells[0].Value.ToString();

        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriYonetimi kategoriYonetimi = new KategoriYonetimi();
            this.Close();
            kategoriYonetimi.ShowDialog();
        }

        private async void kullaniciYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            this.Hide();
            
            kullaniciYonetimi.ShowDialog(this);
        }
    }
}
