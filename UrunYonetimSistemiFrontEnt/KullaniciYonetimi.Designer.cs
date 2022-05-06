
namespace UrunYonetimSistemiFrontEnt
{
    partial class KullaniciYonetimi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgwUrunYonetimi = new System.Windows.Forms.DataGridView();
            this.grpBoxKullaniciBilgileri = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblEklenmeTarihi = new System.Windows.Forms.Label();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnKullaniciGuncelle = new System.Windows.Forms.Button();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.txtBoxSoyadi = new System.Windows.Forms.TextBox();
            this.txtBoxAdi = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.llbSoyadi = new System.Windows.Forms.Label();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.lblAdi = new System.Windows.Forms.Label();
            this.txtBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunYonetimi)).BeginInit();
            this.grpBoxKullaniciBilgileri.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(935, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            this.kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            this.kategoriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            this.kategoriYönetimiToolStripMenuItem.Click += new System.EventHandler(this.kategoriYönetimiToolStripMenuItem_Click);
            // 
            // ürünYonetimiToolStripMenuItem
            // 
            this.ürünYonetimiToolStripMenuItem.Name = "ürünYonetimiToolStripMenuItem";
            this.ürünYonetimiToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.ürünYonetimiToolStripMenuItem.Text = "Ürün Yonetimi";
            this.ürünYonetimiToolStripMenuItem.Click += new System.EventHandler(this.ürünYonetimiToolStripMenuItem_Click);
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
            // dgwUrunYonetimi
            // 
            this.dgwUrunYonetimi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwUrunYonetimi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUrunYonetimi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunYonetimi.Location = new System.Drawing.Point(12, 32);
            this.dgwUrunYonetimi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwUrunYonetimi.Name = "dgwUrunYonetimi";
            this.dgwUrunYonetimi.RowHeadersWidth = 51;
            this.dgwUrunYonetimi.RowTemplate.Height = 24;
            this.dgwUrunYonetimi.Size = new System.Drawing.Size(486, 624);
            this.dgwUrunYonetimi.TabIndex = 5;
            this.dgwUrunYonetimi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUrunYonetimi_CellClick);
            // 
            // grpBoxKullaniciBilgileri
            // 
            this.grpBoxKullaniciBilgileri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxKullaniciBilgileri.Controls.Add(this.lblId);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.lblEklenmeTarihi);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.btnKullaniciSil);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.checkBox1);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.btnKullaniciGuncelle);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.btnKullaniciEkle);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.txtBoxSoyadi);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.txtBoxAdi);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.txtBoxEmail);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.llbSoyadi);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.txtBoxSifre);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.lblAdi);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.txtBoxKullaniciAdi);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.lblEmail);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.label3);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.lblSifre);
            this.grpBoxKullaniciBilgileri.Controls.Add(this.lblKullaniciAdi);
            this.grpBoxKullaniciBilgileri.Location = new System.Drawing.Point(504, 33);
            this.grpBoxKullaniciBilgileri.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpBoxKullaniciBilgileri.Name = "grpBoxKullaniciBilgileri";
            this.grpBoxKullaniciBilgileri.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpBoxKullaniciBilgileri.Size = new System.Drawing.Size(416, 622);
            this.grpBoxKullaniciBilgileri.TabIndex = 6;
            this.grpBoxKullaniciBilgileri.TabStop = false;
            this.grpBoxKullaniciBilgileri.Text = "Kullanici Bilgileri";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(332, 454);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(36, 20);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "#id";
            // 
            // lblEklenmeTarihi
            // 
            this.lblEklenmeTarihi.AutoSize = true;
            this.lblEklenmeTarihi.Location = new System.Drawing.Point(175, 381);
            this.lblEklenmeTarihi.Name = "lblEklenmeTarihi";
            this.lblEklenmeTarihi.Size = new System.Drawing.Size(18, 20);
            this.lblEklenmeTarihi.TabIndex = 7;
            this.lblEklenmeTarihi.Text = "#";
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Location = new System.Drawing.Point(296, 501);
            this.btnKullaniciSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(114, 40);
            this.btnKullaniciSil.TabIndex = 5;
            this.btnKullaniciSil.Text = "Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(27, 454);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(166, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Kullanici Aktif";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnKullaniciGuncelle
            // 
            this.btnKullaniciGuncelle.Location = new System.Drawing.Point(164, 501);
            this.btnKullaniciGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKullaniciGuncelle.Name = "btnKullaniciGuncelle";
            this.btnKullaniciGuncelle.Size = new System.Drawing.Size(114, 40);
            this.btnKullaniciGuncelle.TabIndex = 5;
            this.btnKullaniciGuncelle.Text = "Guncelle";
            this.btnKullaniciGuncelle.UseVisualStyleBackColor = true;
            this.btnKullaniciGuncelle.Click += new System.EventHandler(this.btnKullaniciGuncelle_Click);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Location = new System.Drawing.Point(22, 501);
            this.btnKullaniciEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(114, 40);
            this.btnKullaniciEkle.TabIndex = 5;
            this.btnKullaniciEkle.Text = "Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // txtBoxSoyadi
            // 
            this.txtBoxSoyadi.Location = new System.Drawing.Point(164, 306);
            this.txtBoxSoyadi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxSoyadi.Name = "txtBoxSoyadi";
            this.txtBoxSoyadi.Size = new System.Drawing.Size(231, 25);
            this.txtBoxSoyadi.TabIndex = 1;
            // 
            // txtBoxAdi
            // 
            this.txtBoxAdi.Location = new System.Drawing.Point(164, 236);
            this.txtBoxAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxAdi.Name = "txtBoxAdi";
            this.txtBoxAdi.Size = new System.Drawing.Size(231, 25);
            this.txtBoxAdi.TabIndex = 1;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(164, 171);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(231, 25);
            this.txtBoxEmail.TabIndex = 1;
            // 
            // llbSoyadi
            // 
            this.llbSoyadi.AutoSize = true;
            this.llbSoyadi.Location = new System.Drawing.Point(19, 306);
            this.llbSoyadi.Name = "llbSoyadi";
            this.llbSoyadi.Size = new System.Drawing.Size(63, 20);
            this.llbSoyadi.TabIndex = 0;
            this.llbSoyadi.Text = "Soyadi";
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Location = new System.Drawing.Point(164, 107);
            this.txtBoxSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(231, 25);
            this.txtBoxSifre.TabIndex = 1;
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(19, 236);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(36, 20);
            this.lblAdi.TabIndex = 0;
            this.lblAdi.Text = "Adi";
            // 
            // txtBoxKullaniciAdi
            // 
            this.txtBoxKullaniciAdi.Location = new System.Drawing.Point(164, 51);
            this.txtBoxKullaniciAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxKullaniciAdi.Name = "txtBoxKullaniciAdi";
            this.txtBoxKullaniciAdi.Size = new System.Drawing.Size(231, 25);
            this.txtBoxKullaniciAdi.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(19, 171);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eklenme Tarihi";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(19, 107);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(54, 20);
            this.lblSifre.TabIndex = 0;
            this.lblSifre.Text = "Sifre";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(19, 51);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(126, 20);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanici Adı";
            // 
            // KullaniciYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 669);
            this.Controls.Add(this.grpBoxKullaniciBilgileri);
            this.Controls.Add(this.dgwUrunYonetimi);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KullaniciYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KullaniciYonetimi";
            this.Load += new System.EventHandler(this.KullaniciYonetimi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunYonetimi)).EndInit();
            this.grpBoxKullaniciBilgileri.ResumeLayout(false);
            this.grpBoxKullaniciBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgwUrunYonetimi;
        private System.Windows.Forms.GroupBox grpBoxKullaniciBilgileri;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.Button btnKullaniciGuncelle;
        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtBoxKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.TextBox txtBoxSoyadi;
        private System.Windows.Forms.TextBox txtBoxAdi;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label llbSoyadi;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEklenmeTarihi;
        private System.Windows.Forms.Label lblId;
    }
}