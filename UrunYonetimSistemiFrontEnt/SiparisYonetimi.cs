using BuisnessLayer;
using System;
using System.Threading;
using System.Windows.Forms;
using UrunYonetim.Entites;

namespace UrunYonetimSistemiFrontEnt
{
    public partial class SiparisYonetimi : Form
    {
        public SiparisYonetimi()
        {
            InitializeComponent();
        }
        SiparisManager Smanager = new SiparisManager();
        MusteriManager Mmanager = new MusteriManager();
        UrunManager Umanager = new UrunManager();
        void Yukle()
        {
            dgwSiparisYonetim.DataSource = Smanager.GetAll();
            comboBoxUrunler.DataSource = Umanager.GetAll();
            comboBoxMusteriler.DataSource = Mmanager.GetAll();
            
            dgwSiparisYonetim.Columns[0].Visible = false;
            dgwSiparisYonetim.Columns[2].Visible = false;

            dgwSiparisYonetim.Columns[4].Visible = false;

            lblId.Text = "0";
        }
        private void SiparisYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
            comboBoxUrunler.DisplayMember = "UrunAdi";
            comboBoxUrunler.ValueMember = "id";
            comboBoxMusteriler.DisplayMember = "Ad";
            comboBoxMusteriler.ValueMember = "id";
        }

        void Temizle()
        {
            foreach (Control item in grpBoxSiparisBilgileri.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                    item.Text = string.Empty;
                }

            }

            lblId.Text = "0";

        }
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            try
            {
                var sonuc = Smanager.Add(new Siparis
                {
                    MusteriId = int.Parse(comboBoxMusteriler.SelectedValue.ToString()),
                    SiparisNo = txtBoxSiparisNo.Text,
                    SiparisTarihi = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()),
                    UrunId = int.Parse(comboBoxUrunler.SelectedValue.ToString())
                });
                if (sonuc == 1)
                {
                    MessageBox.Show("Kayit Ekleme Basarili");
                    Thread.Sleep(500);
                    Yukle();
                    Temizle();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSiparisGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    var sonuc = Smanager.Update(new Siparis
                    {
                        id = int.Parse(lblId.Text),
                        MusteriId = int.Parse(comboBoxMusteriler.SelectedValue.ToString()),
                        SiparisNo = txtBoxSiparisNo.Text,
                        SiparisTarihi = dateTimePicker1.Value,
                        UrunId = int.Parse(comboBoxUrunler.SelectedValue.ToString())
                    });
                    if (sonuc == 1)
                    {
                        MessageBox.Show("Kayit Guncelleme Basarili");
                        Thread.Sleep(500);
                        Yukle();
                        Temizle();
                    }
                }
                else
                {

                    MessageBox.Show("Listeden Guncellenicek kaydı seciniz");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSiparisSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "0")
                {
                    int sonuc = Smanager.Delete(int.Parse(lblId.Text));

                    if (sonuc == 1)
                    {
                        MessageBox.Show("Kayit Silme Basarili");
                        Thread.Sleep(500);
                        Yukle();
                        Temizle();
                    }
                }
                else
                {
                    MessageBox.Show("Silinecek kaydı seçiniz");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgwSiparisYonetim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //buraya current row property'si ile tıklanan nesneyi textboxlara doldurmayı yapıcagız.
            lblId.Text = dgwSiparisYonetim.CurrentRow.Cells[0].Value.ToString();
            txtBoxSiparisNo.Text = dgwSiparisYonetim.CurrentRow.Cells[1].Value.ToString();
            comboBoxMusteriler.SelectedValue = int.Parse(dgwSiparisYonetim.CurrentRow.Cells[2].Value.ToString());
            comboBoxUrunler.SelectedValue = int.Parse(dgwSiparisYonetim.CurrentRow.Cells[4].Value.ToString());
            dateTimePicker1.Value = Convert.ToDateTime(dgwSiparisYonetim.CurrentRow.Cells[3].Value.ToString());

        }
    }
}
