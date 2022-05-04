
namespace UrunYonetimSistemiFrontEnt
{
    partial class MusteriYonetimi
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
            this.dgwMusteriYonetim = new System.Windows.Forms.DataGridView();
            this.grpBoxMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMusteriEklenmeTarihi = new System.Windows.Forms.Label();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.txtBoxMusteriSoyadi = new System.Windows.Forms.TextBox();
            this.txtBoxMusteriAdi = new System.Windows.Forms.TextBox();
            this.txtBoxMusteriEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxMusteriAdres = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMusteriTelefon = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriYonetim)).BeginInit();
            this.grpBoxMusteriBilgileri.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1163, 28);
            this.menuStrip1.TabIndex = 2;
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
            // dgwMusteriYonetim
            // 
            this.dgwMusteriYonetim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwMusteriYonetim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMusteriYonetim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusteriYonetim.Location = new System.Drawing.Point(12, 32);
            this.dgwMusteriYonetim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgwMusteriYonetim.Name = "dgwMusteriYonetim";
            this.dgwMusteriYonetim.RowHeadersWidth = 51;
            this.dgwMusteriYonetim.RowTemplate.Height = 24;
            this.dgwMusteriYonetim.Size = new System.Drawing.Size(687, 622);
            this.dgwMusteriYonetim.TabIndex = 1;
            this.dgwMusteriYonetim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwMusteriYonetim_CellClick);
            // 
            // grpBoxMusteriBilgileri
            // 
            this.grpBoxMusteriBilgileri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxMusteriBilgileri.Controls.Add(this.richTextBoxMusteriAdres);
            this.grpBoxMusteriBilgileri.Controls.Add(this.lblId);
            this.grpBoxMusteriBilgileri.Controls.Add(this.lblMusteriEklenmeTarihi);
            this.grpBoxMusteriBilgileri.Controls.Add(this.btnMusteriSil);
            this.grpBoxMusteriBilgileri.Controls.Add(this.checkBox1);
            this.grpBoxMusteriBilgileri.Controls.Add(this.btnMusteriGuncelle);
            this.grpBoxMusteriBilgileri.Controls.Add(this.btnMusteriEkle);
            this.grpBoxMusteriBilgileri.Controls.Add(this.txtBoxMusteriSoyadi);
            this.grpBoxMusteriBilgileri.Controls.Add(this.txtBoxMusteriAdi);
            this.grpBoxMusteriBilgileri.Controls.Add(this.textBoxMusteriTelefon);
            this.grpBoxMusteriBilgileri.Controls.Add(this.txtBoxMusteriEmail);
            this.grpBoxMusteriBilgileri.Controls.Add(this.label6);
            this.grpBoxMusteriBilgileri.Controls.Add(this.label5);
            this.grpBoxMusteriBilgileri.Controls.Add(this.label2);
            this.grpBoxMusteriBilgileri.Controls.Add(this.label1);
            this.grpBoxMusteriBilgileri.Controls.Add(this.label7);
            this.grpBoxMusteriBilgileri.Controls.Add(this.label4);
            this.grpBoxMusteriBilgileri.Controls.Add(this.label3);
            this.grpBoxMusteriBilgileri.Location = new System.Drawing.Point(705, 31);
            this.grpBoxMusteriBilgileri.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpBoxMusteriBilgileri.Name = "grpBoxMusteriBilgileri";
            this.grpBoxMusteriBilgileri.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpBoxMusteriBilgileri.Size = new System.Drawing.Size(446, 622);
            this.grpBoxMusteriBilgileri.TabIndex = 0;
            this.grpBoxMusteriBilgileri.TabStop = false;
            this.grpBoxMusteriBilgileri.Text = "Kullanici Bilgileri";
            this.grpBoxMusteriBilgileri.Enter += new System.EventHandler(this.grpBoxMusteriBilgileri_Enter);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(332, 454);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(27, 17);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "#id";
            // 
            // lblMusteriEklenmeTarihi
            // 
            this.lblMusteriEklenmeTarihi.AutoSize = true;
            this.lblMusteriEklenmeTarihi.Location = new System.Drawing.Point(175, 381);
            this.lblMusteriEklenmeTarihi.Name = "lblMusteriEklenmeTarihi";
            this.lblMusteriEklenmeTarihi.Size = new System.Drawing.Size(16, 17);
            this.lblMusteriEklenmeTarihi.TabIndex = 7;
            this.lblMusteriEklenmeTarihi.Text = "#";
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.Location = new System.Drawing.Point(296, 501);
            this.btnMusteriSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(114, 40);
            this.btnMusteriSil.TabIndex = 9;
            this.btnMusteriSil.Text = "Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = true;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(164, 453);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Musteri Aktif";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(164, 501);
            this.btnMusteriGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(114, 40);
            this.btnMusteriGuncelle.TabIndex = 8;
            this.btnMusteriGuncelle.Text = "Guncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = true;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(22, 501);
            this.btnMusteriEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(114, 40);
            this.btnMusteriEkle.TabIndex = 7;
            this.btnMusteriEkle.Text = "Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // txtBoxMusteriSoyadi
            // 
            this.txtBoxMusteriSoyadi.Location = new System.Drawing.Point(164, 119);
            this.txtBoxMusteriSoyadi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxMusteriSoyadi.Name = "txtBoxMusteriSoyadi";
            this.txtBoxMusteriSoyadi.Size = new System.Drawing.Size(231, 22);
            this.txtBoxMusteriSoyadi.TabIndex = 2;
            // 
            // txtBoxMusteriAdi
            // 
            this.txtBoxMusteriAdi.Location = new System.Drawing.Point(164, 52);
            this.txtBoxMusteriAdi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxMusteriAdi.Name = "txtBoxMusteriAdi";
            this.txtBoxMusteriAdi.Size = new System.Drawing.Size(231, 22);
            this.txtBoxMusteriAdi.TabIndex = 1;
            // 
            // txtBoxMusteriEmail
            // 
            this.txtBoxMusteriEmail.Location = new System.Drawing.Point(164, 181);
            this.txtBoxMusteriEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxMusteriEmail.Name = "txtBoxMusteriEmail";
            this.txtBoxMusteriEmail.Size = new System.Drawing.Size(231, 22);
            this.txtBoxMusteriEmail.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Soyadi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Eklenme Tarihi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adres";
            // 
            // richTextBoxMusteriAdres
            // 
            this.richTextBoxMusteriAdres.Location = new System.Drawing.Point(164, 290);
            this.richTextBoxMusteriAdres.Name = "richTextBoxMusteriAdres";
            this.richTextBoxMusteriAdres.Size = new System.Drawing.Size(231, 73);
            this.richTextBoxMusteriAdres.TabIndex = 5;
            this.richTextBoxMusteriAdres.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Telefon";
            // 
            // textBoxMusteriTelefon
            // 
            this.textBoxMusteriTelefon.Location = new System.Drawing.Point(164, 235);
            this.textBoxMusteriTelefon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMusteriTelefon.Name = "textBoxMusteriTelefon";
            this.textBoxMusteriTelefon.Size = new System.Drawing.Size(231, 22);
            this.textBoxMusteriTelefon.TabIndex = 4;
            // 
            // MusteriYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 667);
            this.Controls.Add(this.grpBoxMusteriBilgileri);
            this.Controls.Add(this.dgwMusteriYonetim);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MusteriYonetimi";
            this.Text = "MusteriYonetimi";
            this.Load += new System.EventHandler(this.MusteriYonetimi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusteriYonetim)).EndInit();
            this.grpBoxMusteriBilgileri.ResumeLayout(false);
            this.grpBoxMusteriBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünYonetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgwMusteriYonetim;
        private System.Windows.Forms.GroupBox grpBoxMusteriBilgileri;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMusteriEklenmeTarihi;
        private System.Windows.Forms.Button btnMusteriSil;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnMusteriGuncelle;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.TextBox txtBoxMusteriSoyadi;
        private System.Windows.Forms.TextBox txtBoxMusteriAdi;
        private System.Windows.Forms.TextBox txtBoxMusteriEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxMusteriAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMusteriTelefon;
        private System.Windows.Forms.Label label7;
    }
}