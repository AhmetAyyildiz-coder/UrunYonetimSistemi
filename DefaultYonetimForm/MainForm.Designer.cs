﻿
namespace DefaultYonetimForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.btnKategoriGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.chBoxKategoriEklenmeTarihi = new System.Windows.Forms.CheckBox();
            this.dateKategoriEklenmeTarih = new System.Windows.Forms.DateTimePicker();
            this.rTxtBoxKategoriAciklama = new System.Windows.Forms.RichTextBox();
            this.txtboxKategoriAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullaniciYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYonetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxKategoriYonetim = new System.Windows.Forms.GroupBox();
            this.dtwKategoriler = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grpBoxKategoriYonetim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtwKategoriler)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.Location = new System.Drawing.Point(334, 287);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(131, 32);
            this.btnKategoriSil.TabIndex = 5;
            this.btnKategoriSil.Text = "Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = true;
            // 
            // btnKategoriGuncelle
            // 
            this.btnKategoriGuncelle.Location = new System.Drawing.Point(175, 287);
            this.btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            this.btnKategoriGuncelle.Size = new System.Drawing.Size(131, 32);
            this.btnKategoriGuncelle.TabIndex = 5;
            this.btnKategoriGuncelle.Text = "Guncelle";
            this.btnKategoriGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(21, 287);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(131, 32);
            this.btnKategoriEkle.TabIndex = 5;
            this.btnKategoriEkle.Text = "Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            // 
            // chBoxKategoriEklenmeTarihi
            // 
            this.chBoxKategoriEklenmeTarihi.AutoSize = true;
            this.chBoxKategoriEklenmeTarihi.Location = new System.Drawing.Point(190, 240);
            this.chBoxKategoriEklenmeTarihi.Name = "chBoxKategoriEklenmeTarihi";
            this.chBoxKategoriEklenmeTarihi.Size = new System.Drawing.Size(96, 21);
            this.chBoxKategoriEklenmeTarihi.TabIndex = 4;
            this.chBoxKategoriEklenmeTarihi.Text = "Ürün Aktif ";
            this.chBoxKategoriEklenmeTarihi.UseVisualStyleBackColor = true;
            // 
            // dateKategoriEklenmeTarih
            // 
            this.dateKategoriEklenmeTarih.Location = new System.Drawing.Point(190, 189);
            this.dateKategoriEklenmeTarih.Name = "dateKategoriEklenmeTarih";
            this.dateKategoriEklenmeTarih.Size = new System.Drawing.Size(247, 22);
            this.dateKategoriEklenmeTarih.TabIndex = 3;
            // 
            // rTxtBoxKategoriAciklama
            // 
            this.rTxtBoxKategoriAciklama.Location = new System.Drawing.Point(190, 92);
            this.rTxtBoxKategoriAciklama.Name = "rTxtBoxKategoriAciklama";
            this.rTxtBoxKategoriAciklama.Size = new System.Drawing.Size(247, 72);
            this.rTxtBoxKategoriAciklama.TabIndex = 2;
            this.rTxtBoxKategoriAciklama.Text = "";
            // 
            // txtboxKategoriAdi
            // 
            this.txtboxKategoriAdi.Location = new System.Drawing.Point(190, 44);
            this.txtboxKategoriAdi.Name = "txtboxKategoriAdi";
            this.txtboxKategoriAdi.Size = new System.Drawing.Size(247, 22);
            this.txtboxKategoriAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eklenme Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aciklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Adı";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // kullaniciYönetimiToolStripMenuItem
            // 
            this.kullaniciYönetimiToolStripMenuItem.Name = "kullaniciYönetimiToolStripMenuItem";
            this.kullaniciYönetimiToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.kullaniciYönetimiToolStripMenuItem.Text = "Kullanici Yönetimi";
            // 
            // ürünYonetimiToolStripMenuItem
            // 
            this.ürünYonetimiToolStripMenuItem.Name = "ürünYonetimiToolStripMenuItem";
            this.ürünYonetimiToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.ürünYonetimiToolStripMenuItem.Text = "Ürün Yonetimi";
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            this.kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            this.kategoriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            // 
            // grpBoxKategoriYonetim
            // 
            this.grpBoxKategoriYonetim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxKategoriYonetim.Controls.Add(this.btnKategoriSil);
            this.grpBoxKategoriYonetim.Controls.Add(this.btnKategoriGuncelle);
            this.grpBoxKategoriYonetim.Controls.Add(this.btnKategoriEkle);
            this.grpBoxKategoriYonetim.Controls.Add(this.chBoxKategoriEklenmeTarihi);
            this.grpBoxKategoriYonetim.Controls.Add(this.dateKategoriEklenmeTarih);
            this.grpBoxKategoriYonetim.Controls.Add(this.rTxtBoxKategoriAciklama);
            this.grpBoxKategoriYonetim.Controls.Add(this.txtboxKategoriAdi);
            this.grpBoxKategoriYonetim.Controls.Add(this.label3);
            this.grpBoxKategoriYonetim.Controls.Add(this.label2);
            this.grpBoxKategoriYonetim.Controls.Add(this.label1);
            this.grpBoxKategoriYonetim.Location = new System.Drawing.Point(712, 32);
            this.grpBoxKategoriYonetim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxKategoriYonetim.Name = "grpBoxKategoriYonetim";
            this.grpBoxKategoriYonetim.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBoxKategoriYonetim.Size = new System.Drawing.Size(463, 468);
            this.grpBoxKategoriYonetim.TabIndex = 5;
            this.grpBoxKategoriYonetim.TabStop = false;
            this.grpBoxKategoriYonetim.Text = "Kategori yönetim";
            // 
            // dtwKategoriler
            // 
            this.dtwKategoriler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtwKategoriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtwKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwKategoriler.Location = new System.Drawing.Point(12, 31);
            this.dtwKategoriler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtwKategoriler.Name = "dtwKategoriler";
            this.dtwKategoriler.RowHeadersWidth = 51;
            this.dtwKategoriler.RowTemplate.Height = 24;
            this.dtwKategoriler.Size = new System.Drawing.Size(694, 468);
            this.dtwKategoriler.TabIndex = 4;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1187, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 512);
            this.Controls.Add(this.grpBoxKategoriYonetim);
            this.Controls.Add(this.dtwKategoriler);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpBoxKategoriYonetim.ResumeLayout(false);
            this.grpBoxKategoriYonetim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtwKategoriler)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnKategoriSil;
        public System.Windows.Forms.Button btnKategoriGuncelle;
        public System.Windows.Forms.Button btnKategoriEkle;
        public System.Windows.Forms.CheckBox chBoxKategoriEklenmeTarihi;
        public System.Windows.Forms.DateTimePicker dateKategoriEklenmeTarih;
        public System.Windows.Forms.RichTextBox rTxtBoxKategoriAciklama;
        public System.Windows.Forms.TextBox txtboxKategoriAdi;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kullaniciYönetimiToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ürünYonetimiToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        public System.Windows.Forms.GroupBox grpBoxKategoriYonetim;
        public System.Windows.Forms.DataGridView dtwKategoriler;
        public System.Windows.Forms.MenuStrip menuStrip1;
    }
}

