using System;
using System.Windows.Forms;
using UrunYonetim.BuisnessLayer;
using UrunYonetimi.Entites;

namespace UrunYonetimSistemiFrontEnt
{
    public partial class MarkaYonetimi : Form
    {
        MarkaManager markaManager;
        int markaİd = 0;
        DialogResult result = new DialogResult();
        public MarkaYonetimi()
        {
            InitializeComponent();
            markaManager = new MarkaManager();
        }
        void GridDoldur()
        {
            dgwMarkalar.DataSource = markaManager.GetAll();
            dgwMarkalar.Columns[0].Visible = false;
        }
        private void MarkaYonetimi_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        /// <summary>
        /// Marka Yonetim icin txtBox Temizleme fonksiyonu
        /// </summary>
        void TxtBoxTemizle()
        {
            foreach (Control item in this.grpBoxMarkaYonetimi.Controls)
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
                lblEklenmeTarihi.Text = "Urun Ekleme Tarihi " +
                    "Suanki Tarih Secilecektir.";

            }

        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            if (markaManager.MarkaKontrol(markaİd) == 10)
            {
                MessageBox.Show("Bu kayıtta zaten sistemde bulunuyor. Tekrar Ekleyemezsiniz. Lütfen yeni kayit ekleyin.");
                TxtBoxTemizle();
            }
            else
            {
                int islemsonucu = markaManager.Add(new Marka
                {
                    Aciklama = rtxtBoxMarkaAciklama.Text,
                    EklenmeTarihi = DateTime.Now,
                    AktifMi = cboxAktifmi.Checked,
                    MarkaAdi = txtBoxMarkaAdi.Text
                });
                if (islemsonucu > 0)
                {
                    GridDoldur();
                    result = MessageBox.Show("Tebrikler Kayit Ekleme Basarili");
                    if (result == DialogResult.OK)
                    {
                        TxtBoxTemizle();
                    }
                }
            }



        }

        //DataGridView'da herhangi bir yere tıklanıldıgında o datayı sağdaki textBox'a aktarmayı saglayan event
        private void dgwMarkalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            markaİd = int.Parse(dgwMarkalar.Rows[e.RowIndex].Cells[0].Value.ToString());
            int rowIndex = e.RowIndex;

            txtBoxMarkaAdi.Text = dgwMarkalar.Rows[e.RowIndex].Cells[1].Value.ToString();
            rtxtBoxMarkaAciklama.Text = dgwMarkalar.Rows[e.RowIndex].Cells[2].Value.ToString();
            lblEklenmeTarihi.Text = dgwMarkalar.Rows[e.RowIndex].Cells[3].Value.ToString();
            cboxAktifmi.Checked = (bool)dgwMarkalar.Rows[e.RowIndex].Cells[4].Value;
        }

        //gridview'den değiştirilen ogeyi bulup güncellemesini yapacağız.
        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            int sonuc = 0;

            try
            {
                sonuc = markaManager.Update(new Marka
                {

                    id = markaİd,
                    Aciklama = rtxtBoxMarkaAciklama.Text,
                    AktifMi = cboxAktifmi.Checked,
                    EklenmeTarihi = Convert.ToDateTime(lblEklenmeTarihi.Text),
                    MarkaAdi = txtBoxMarkaAdi.Text
                });
            }
            catch (Exception ex)
            {

                MessageBox.Show("lutfen guncellenicek veriyi işaretleyin  !");
            }

            if (sonuc > 0)
            {
                result = MessageBox.Show("Kayit Basarili Sekilde Guncellendi");
                if (result == DialogResult.OK)
                {
                    TxtBoxTemizle();
                    GridDoldur();
                }

            }
        }

        private void btnMarkaSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("secili kaydı silmek istediğinize emin misiniz ?", "Uyarı !", MessageBoxButtons.OKCancel);

            if (dialog == DialogResult.OK)
            {
                if (markaİd > 0)
                {
                    int sonuc = markaManager.Delete(markaİd);
                    if (sonuc == 1)
                    {
                        result = MessageBox.Show("Kayit silme basarili");
                        if (result == DialogResult.OK)
                        {
                            TxtBoxTemizle();
                            GridDoldur();
                            markaİd = 0;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Kayit Silme Basarisiz");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen silmek için bir data seçin");
                }
            }


        }
    }
}
