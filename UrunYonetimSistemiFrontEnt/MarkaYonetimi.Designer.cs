
namespace UrunYonetimSistemiFrontEnt
{
    partial class MarkaYonetimi
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
            this.dgwMarkalar = new System.Windows.Forms.DataGridView();
            this.grpBoxMarkaYonetimi = new System.Windows.Forms.GroupBox();
            this.lblid = new System.Windows.Forms.Label();
            this.lblEklenmeTarihi = new System.Windows.Forms.Label();
            this.btnMarkaSil = new System.Windows.Forms.Button();
            this.btnMarkaGuncelle = new System.Windows.Forms.Button();
            this.btnMarkaEkle = new System.Windows.Forms.Button();
            this.cboxAktifmi = new System.Windows.Forms.CheckBox();
            this.rtxtBoxMarkaAciklama = new System.Windows.Forms.RichTextBox();
            this.txtBoxMarkaAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMarkalar)).BeginInit();
            this.grpBoxMarkaYonetimi.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1113, 28);
            this.menuStrip1.TabIndex = 1;
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
            // dgwMarkalar
            // 
            this.dgwMarkalar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwMarkalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMarkalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMarkalar.Location = new System.Drawing.Point(14, 56);
            this.dgwMarkalar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwMarkalar.Name = "dgwMarkalar";
            this.dgwMarkalar.RowHeadersWidth = 51;
            this.dgwMarkalar.RowTemplate.Height = 24;
            this.dgwMarkalar.Size = new System.Drawing.Size(554, 435);
            this.dgwMarkalar.TabIndex = 2;
            this.dgwMarkalar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMarkalar_CellClick);
            this.dgwMarkalar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMarkalar_CellContentClick);
            // 
            // grpBoxMarkaYonetimi
            // 
            this.grpBoxMarkaYonetimi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxMarkaYonetimi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBoxMarkaYonetimi.Controls.Add(this.lblid);
            this.grpBoxMarkaYonetimi.Controls.Add(this.lblEklenmeTarihi);
            this.grpBoxMarkaYonetimi.Controls.Add(this.btnMarkaSil);
            this.grpBoxMarkaYonetimi.Controls.Add(this.btnMarkaGuncelle);
            this.grpBoxMarkaYonetimi.Controls.Add(this.btnMarkaEkle);
            this.grpBoxMarkaYonetimi.Controls.Add(this.cboxAktifmi);
            this.grpBoxMarkaYonetimi.Controls.Add(this.rtxtBoxMarkaAciklama);
            this.grpBoxMarkaYonetimi.Controls.Add(this.txtBoxMarkaAdi);
            this.grpBoxMarkaYonetimi.Controls.Add(this.label3);
            this.grpBoxMarkaYonetimi.Controls.Add(this.label2);
            this.grpBoxMarkaYonetimi.Controls.Add(this.label1);
            this.grpBoxMarkaYonetimi.Location = new System.Drawing.Point(574, 56);
            this.grpBoxMarkaYonetimi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpBoxMarkaYonetimi.Name = "grpBoxMarkaYonetimi";
            this.grpBoxMarkaYonetimi.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpBoxMarkaYonetimi.Size = new System.Drawing.Size(530, 435);
            this.grpBoxMarkaYonetimi.TabIndex = 3;
            this.grpBoxMarkaYonetimi.TabStop = false;
            this.grpBoxMarkaYonetimi.Text = "Marka yönetim";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(428, 304);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 20);
            this.lblid.TabIndex = 4;
            this.lblid.Text = "0";
            // 
            // lblEklenmeTarihi
            // 
            this.lblEklenmeTarihi.AutoSize = true;
            this.lblEklenmeTarihi.Location = new System.Drawing.Point(219, 236);
            this.lblEklenmeTarihi.Name = "lblEklenmeTarihi";
            this.lblEklenmeTarihi.Size = new System.Drawing.Size(243, 40);
            this.lblEklenmeTarihi.TabIndex = 6;
            this.lblEklenmeTarihi.Text = "Urun Ekleme Tarihi \r\nSuanki Tarih Secilecektir.";
            // 
            // btnMarkaSil
            // 
            this.btnMarkaSil.Location = new System.Drawing.Point(376, 359);
            this.btnMarkaSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMarkaSil.Name = "btnMarkaSil";
            this.btnMarkaSil.Size = new System.Drawing.Size(147, 40);
            this.btnMarkaSil.TabIndex = 5;
            this.btnMarkaSil.Text = "Sil";
            this.btnMarkaSil.UseVisualStyleBackColor = true;
            this.btnMarkaSil.Click += new System.EventHandler(this.btnMarkaSil_Click);
            // 
            // btnMarkaGuncelle
            // 
            this.btnMarkaGuncelle.Location = new System.Drawing.Point(197, 359);
            this.btnMarkaGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            this.btnMarkaGuncelle.Size = new System.Drawing.Size(147, 40);
            this.btnMarkaGuncelle.TabIndex = 5;
            this.btnMarkaGuncelle.Text = "Guncelle";
            this.btnMarkaGuncelle.UseVisualStyleBackColor = true;
            this.btnMarkaGuncelle.Click += new System.EventHandler(this.btnMarkaGuncelle_Click);
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.Location = new System.Drawing.Point(24, 359);
            this.btnMarkaEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.Size = new System.Drawing.Size(147, 40);
            this.btnMarkaEkle.TabIndex = 5;
            this.btnMarkaEkle.Text = "Ekle";
            this.btnMarkaEkle.UseVisualStyleBackColor = true;
            this.btnMarkaEkle.Click += new System.EventHandler(this.btnMarkaEkle_Click);
            // 
            // cboxAktifmi
            // 
            this.cboxAktifmi.AutoSize = true;
            this.cboxAktifmi.Location = new System.Drawing.Point(214, 300);
            this.cboxAktifmi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxAktifmi.Name = "cboxAktifmi";
            this.cboxAktifmi.Size = new System.Drawing.Size(130, 24);
            this.cboxAktifmi.TabIndex = 4;
            this.cboxAktifmi.Text = "Marka Aktif";
            this.cboxAktifmi.UseVisualStyleBackColor = true;
            // 
            // rtxtBoxMarkaAciklama
            // 
            this.rtxtBoxMarkaAciklama.Location = new System.Drawing.Point(214, 115);
            this.rtxtBoxMarkaAciklama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtxtBoxMarkaAciklama.Name = "rtxtBoxMarkaAciklama";
            this.rtxtBoxMarkaAciklama.Size = new System.Drawing.Size(277, 89);
            this.rtxtBoxMarkaAciklama.TabIndex = 2;
            this.rtxtBoxMarkaAciklama.Text = "";
            // 
            // txtBoxMarkaAdi
            // 
            this.txtBoxMarkaAdi.Location = new System.Drawing.Point(214, 55);
            this.txtBoxMarkaAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxMarkaAdi.Name = "txtBoxMarkaAdi";
            this.txtBoxMarkaAdi.Size = new System.Drawing.Size(277, 25);
            this.txtBoxMarkaAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eklenme Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Aciklama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka Adı";
            // 
            // MarkaYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 502);
            this.Controls.Add(this.grpBoxMarkaYonetimi);
            this.Controls.Add(this.dgwMarkalar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MarkaYonetimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarkaYonetimi";
            this.Load += new System.EventHandler(this.MarkaYonetimi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMarkalar)).EndInit();
            this.grpBoxMarkaYonetimi.ResumeLayout(false);
            this.grpBoxMarkaYonetimi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgwMarkalar;
        private System.Windows.Forms.GroupBox grpBoxMarkaYonetimi;
        private System.Windows.Forms.Button btnMarkaSil;
        private System.Windows.Forms.Button btnMarkaGuncelle;
        private System.Windows.Forms.Button btnMarkaEkle;
        private System.Windows.Forms.CheckBox cboxAktifmi;
        private System.Windows.Forms.RichTextBox rtxtBoxMarkaAciklama;
        private System.Windows.Forms.TextBox txtBoxMarkaAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEklenmeTarihi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblid;
    }
}