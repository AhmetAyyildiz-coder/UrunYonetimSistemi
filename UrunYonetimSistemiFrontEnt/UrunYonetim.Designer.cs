
namespace UrunYonetimSistemiFrontEnt
{
    partial class UrunYonetim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwUrunYonetimi = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxKategoriYonetim = new System.Windows.Forms.GroupBox();
            this.dateUrunEklenmeTarihi = new System.Windows.Forms.DateTimePicker();
            this.rTxtBoxUrunAciklama = new System.Windows.Forms.RichTextBox();
            this.txtBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chboxUrunAktif = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUrunSil = new System.Windows.Forms.Button();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtStokMiktari = new System.Windows.Forms.TextBox();
            this.comboBoxUrunKategori = new System.Windows.Forms.ComboBox();
            this.comboBoxUrunMarka = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunYonetimi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpBoxKategoriYonetim.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUrunYonetimi
            // 
            this.dgwUrunYonetimi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunYonetimi.Location = new System.Drawing.Point(12, 48);
            this.dgwUrunYonetimi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwUrunYonetimi.Name = "dgwUrunYonetimi";
            this.dgwUrunYonetimi.RowHeadersWidth = 51;
            this.dgwUrunYonetimi.RowTemplate.Height = 24;
            this.dgwUrunYonetimi.Size = new System.Drawing.Size(486, 610);
            this.dgwUrunYonetimi.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriYönetimiToolStripMenuItem,
            this.ürünYonetimiToolStripMenuItem,
            this.kullaniciYönetimiToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            this.kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            this.kategoriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            // 
            // ürünYonetimiToolStripMenuItem
            // 
            this.ürünYonetimiToolStripMenuItem.Name = "ürünYonetimiToolStripMenuItem";
            this.ürünYonetimiToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.ürünYonetimiToolStripMenuItem.Text = "Ürün Yonetimi";
            // 
            // kullaniciYönetimiToolStripMenuItem
            // 
            this.kullaniciYönetimiToolStripMenuItem.Name = "kullaniciYönetimiToolStripMenuItem";
            this.kullaniciYönetimiToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.kullaniciYönetimiToolStripMenuItem.Text = "Kullanici Yönetimi";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // grpBoxKategoriYonetim
            // 
            this.grpBoxKategoriYonetim.Controls.Add(this.comboBoxUrunMarka);
            this.grpBoxKategoriYonetim.Controls.Add(this.comboBoxUrunKategori);
            this.grpBoxKategoriYonetim.Controls.Add(this.dateUrunEklenmeTarihi);
            this.grpBoxKategoriYonetim.Controls.Add(this.rTxtBoxUrunAciklama);
            this.grpBoxKategoriYonetim.Controls.Add(this.txtStokMiktari);
            this.grpBoxKategoriYonetim.Controls.Add(this.textBox1);
            this.grpBoxKategoriYonetim.Controls.Add(this.txtUrunFiyati);
            this.grpBoxKategoriYonetim.Controls.Add(this.txtBoxUrunAdi);
            this.grpBoxKategoriYonetim.Controls.Add(this.label3);
            this.grpBoxKategoriYonetim.Controls.Add(this.label8);
            this.grpBoxKategoriYonetim.Controls.Add(this.label7);
            this.grpBoxKategoriYonetim.Controls.Add(this.label6);
            this.grpBoxKategoriYonetim.Controls.Add(this.label5);
            this.grpBoxKategoriYonetim.Controls.Add(this.label4);
            this.grpBoxKategoriYonetim.Controls.Add(this.label2);
            this.grpBoxKategoriYonetim.Controls.Add(this.chboxUrunAktif);
            this.grpBoxKategoriYonetim.Controls.Add(this.label1);
            this.grpBoxKategoriYonetim.Location = new System.Drawing.Point(504, 48);
            this.grpBoxKategoriYonetim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxKategoriYonetim.Name = "grpBoxKategoriYonetim";
            this.grpBoxKategoriYonetim.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxKategoriYonetim.Size = new System.Drawing.Size(529, 571);
            this.grpBoxKategoriYonetim.TabIndex = 5;
            this.grpBoxKategoriYonetim.TabStop = false;
            this.grpBoxKategoriYonetim.Text = "Urun Bilgileri";
            this.grpBoxKategoriYonetim.Enter += new System.EventHandler(this.grpBoxKategoriYonetim_Enter);
            // 
            // dateUrunEklenmeTarihi
            // 
            this.dateUrunEklenmeTarihi.Location = new System.Drawing.Point(190, 483);
            this.dateUrunEklenmeTarihi.Name = "dateUrunEklenmeTarihi";
            this.dateUrunEklenmeTarihi.Size = new System.Drawing.Size(290, 25);
            this.dateUrunEklenmeTarihi.TabIndex = 3;
            // 
            // rTxtBoxUrunAciklama
            // 
            this.rTxtBoxUrunAciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rTxtBoxUrunAciklama.Location = new System.Drawing.Point(190, 92);
            this.rTxtBoxUrunAciklama.Name = "rTxtBoxUrunAciklama";
            this.rTxtBoxUrunAciklama.Size = new System.Drawing.Size(290, 72);
            this.rTxtBoxUrunAciklama.TabIndex = 2;
            this.rTxtBoxUrunAciklama.Text = "";
            // 
            // txtBoxUrunAdi
            // 
            this.txtBoxUrunAdi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxUrunAdi.Location = new System.Drawing.Point(190, 44);
            this.txtBoxUrunAdi.Name = "txtBoxUrunAdi";
            this.txtBoxUrunAdi.Size = new System.Drawing.Size(290, 25);
            this.txtBoxUrunAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eklenme Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aciklama";
            // 
            // chboxUrunAktif
            // 
            this.chboxUrunAktif.AutoSize = true;
            this.chboxUrunAktif.Location = new System.Drawing.Point(190, 530);
            this.chboxUrunAktif.Name = "chboxUrunAktif";
            this.chboxUrunAktif.Size = new System.Drawing.Size(130, 24);
            this.chboxUrunAktif.TabIndex = 4;
            this.chboxUrunAktif.Text = "Ürün Aktif ";
            this.chboxUrunAktif.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urun Adı";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(835, 626);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(131, 32);
            this.btnUrunSil.TabIndex = 5;
            this.btnUrunSil.Text = "Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(676, 626);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(131, 32);
            this.btnUrunGuncelle.TabIndex = 5;
            this.btnUrunGuncelle.Text = "Guncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(522, 626);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(131, 32);
            this.btnUrunEkle.TabIndex = 5;
            this.btnUrunEkle.Text = "Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Urun Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "KDV ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Stok Miktarı";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrunFiyati.Location = new System.Drawing.Point(190, 196);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(290, 25);
            this.txtUrunFiyati.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(190, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 25);
            this.textBox1.TabIndex = 1;
            // 
            // txtStokMiktari
            // 
            this.txtStokMiktari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStokMiktari.Location = new System.Drawing.Point(190, 340);
            this.txtStokMiktari.Name = "txtStokMiktari";
            this.txtStokMiktari.Size = new System.Drawing.Size(290, 25);
            this.txtStokMiktari.TabIndex = 1;
            // 
            // comboBoxUrunKategori
            // 
            this.comboBoxUrunKategori.FormattingEnabled = true;
            this.comboBoxUrunKategori.Location = new System.Drawing.Point(190, 390);
            this.comboBoxUrunKategori.Name = "comboBoxUrunKategori";
            this.comboBoxUrunKategori.Size = new System.Drawing.Size(290, 28);
            this.comboBoxUrunKategori.TabIndex = 5;
            // 
            // comboBoxUrunMarka
            // 
            this.comboBoxUrunMarka.FormattingEnabled = true;
            this.comboBoxUrunMarka.Location = new System.Drawing.Point(190, 436);
            this.comboBoxUrunMarka.Name = "comboBoxUrunMarka";
            this.comboBoxUrunMarka.Size = new System.Drawing.Size(290, 28);
            this.comboBoxUrunMarka.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kategori";
            this.label7.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Marka";
            this.label8.Click += new System.EventHandler(this.label6_Click);
            // 
            // UrunYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 678);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.grpBoxKategoriYonetim);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.btnUrunEkle);
            this.Controls.Add(this.dgwUrunYonetimi);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UrunYonetim";
            this.Text = "UrunYonetim";
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunYonetimi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBoxKategoriYonetim.ResumeLayout(false);
            this.grpBoxKategoriYonetim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUrunYonetimi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBoxKategoriYonetim;
        private System.Windows.Forms.DateTimePicker dateUrunEklenmeTarihi;
        private System.Windows.Forms.RichTextBox rTxtBoxUrunAciklama;
        private System.Windows.Forms.TextBox txtBoxUrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chboxUrunAktif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUrunSil;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStokMiktari;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxUrunMarka;
        private System.Windows.Forms.ComboBox comboBoxUrunKategori;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}