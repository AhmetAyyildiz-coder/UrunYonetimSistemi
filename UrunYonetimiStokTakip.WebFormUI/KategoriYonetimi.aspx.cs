using BuisnessLayer;
using System;
using UrunYonetimi.Entites;

namespace UrunYonetimiStokTakip.WebFormUI
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        KategoriManager manager = new KategoriManager();
        void Yukle()
        {
            GridView1.DataSource = manager.GetAll();
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Yukle();
            lblTarih.Text = DateTime.Now.ToShortDateString();
        }

        protected void cbDurum_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxKategoriAdi.Text) && string.IsNullOrWhiteSpace(txtBoxKategoriAciklama.Text))
            {
                lblUyarı.Text = "Kategori Adı ve Aciklama Bos Gecilemez";
                lblUyarı.ForeColor = System.Drawing.Color.Red;
               
            }
            else
            {
                try
                {
                    var sonuc = manager.Add(new Kategori()
                    {
                        Aciklama = txtBoxKategoriAciklama.Text,
                        AktifMi = cbDurum.Checked,
                        EklenmeTarihi = DateTime.Now,
                        KategoriAdi = txtBoxKategoriAdi.Text
                    });

                    if (sonuc == 1)
                    {
                        //DialogResult result = MessageBox.Show("Kayıt Eklenildi.");
                        //if (result == DialogResult.OK)
                        //{
                        //    Thread.Sleep(1000);
                        //   
                        //    temizle();

                        //}
                        //Yukle();

                        //bizim winform tarafındaki temizle ve yukle metodunu direkt bir yonlendirme
                        //ile tek response nesnesi ile burada web kısmında yaptık. Bu sayede ekle metodu sorunsuz çalışıyor.
                        Response.Redirect("KategoriYonetimi.aspx");
                        
                    }
                    else
                    {
                        lblUyarı.Text = "Kayıt Eklenemdi. !";
                    }
                }
                catch (Exception ex)
                {

                    lblUyarı.Text = "Kayıt Eklenirken bir hata olustu . Hata Kodu => " + ex.Message;
                }
            }
        }

        protected void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        protected void btnSil_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdated(object sender, System.Web.UI.WebControls.GridViewUpdatedEventArgs e)
        {

        }
    }
}