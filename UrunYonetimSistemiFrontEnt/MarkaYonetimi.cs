using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrunYonetim.BuisnessLayer;

namespace UrunYonetimSistemiFrontEnt
{
    public partial class MarkaYonetimi : Form
    {
        MarkaManager markaManager;
        
        public MarkaYonetimi()
        {
            InitializeComponent();
            markaManager = new MarkaManager();
        }
        void GridDoldur() {
            dgwMarkalar.DataSource = markaManager.GetAll();
        }
        private void MarkaYonetimi_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }
    }
}
