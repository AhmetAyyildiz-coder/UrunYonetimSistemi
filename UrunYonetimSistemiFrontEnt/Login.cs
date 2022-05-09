using BuisnessLayer;
using System;
using System.Windows.Forms;

namespace UrunYonetimSistemiFrontEnt
{
    public partial class Login : Form
    {
        KullaniciManager manager = new KullaniciManager();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtBoxSifre.Text))
            {
                MessageBox.Show("Kullanici Adi ve Sifre Bos gecilemez");
            }
            else
            {
                //duzeltilecek
                //var kullanici = manager.Find(txtBoxKullaniciAdi.Text, txtBoxSifre.Text);
                //if (kullanici != null)
                //{
                //    Menu mainMenu = new Menu();
                //    this.Hide();
                //    DialogResult result = mainMenu.ShowDialog();
                //    if (result == DialogResult.Cancel)
                //    {
                //        this.Close();
                //    }
            }
            //else
            //{
            //    MessageBox.Show("Giriş Başarısız. Kullanici Bulunamadi");
            //}
        }



        //Application.OpenForms["Login"].Close();
        //mainMenu.ShowDialog();


    } 


    }

