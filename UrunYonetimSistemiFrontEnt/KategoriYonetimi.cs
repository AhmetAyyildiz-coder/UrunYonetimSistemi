using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunYonetimSistemiFrontEnt
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {

        }

        private void dtwKategoriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //            lblId.Text = dgwUrunYonetimi.CurrentRow.Cells[0].Value.ToString();

            lblId.Text = dtwKategoriler.CurrentRow.Cells[0].Value.ToString();
            rTxtBoxKategoriAciklama.Text = dtwKategoriler.CurrentRow.Cells[2].Value.ToString();
            txtboxKategoriAdi.Text = dtwKategoriler.CurrentRow.Cells[1].Value.ToString();
            chBoxKategoriAktif.Checked = Convert.ToBoolean(dtwKategoriler.CurrentRow.Cells[4].Value);
            lblEklenmeTarihi.Text = dtwKategoriler.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
