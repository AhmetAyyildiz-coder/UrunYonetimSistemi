namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDbBaglantili : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategori",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(),
                        Aciklama = c.String(),
                        EklenmeTarihi = c.DateTime(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        kullaniciAdi = c.String(),
                        sifre = c.String(),
                        Email = c.String(),
                        Ad = c.String(),
                        Soyad = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Marka",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        MarkaAdi = c.String(),
                        Aciklama = c.String(),
                        EklenmeTarihi = c.DateTime(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Musteri",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Email = c.String(),
                        Telefon = c.String(),
                        Adres = c.String(),
                        EklenmeTarihi = c.DateTime(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Siparis",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        SiparisNo = c.String(),
                        MusteriId = c.Int(nullable: false),
                        SiparisTarihi = c.DateTime(nullable: false),
                        UrunId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Musteri", t => t.MusteriId, cascadeDelete: true)
                .ForeignKey("dbo.Urun", t => t.UrunId, cascadeDelete: true)
                .Index(t => t.MusteriId)
                .Index(t => t.UrunId);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        KategoriId = c.Int(nullable: false),
                        MarkaId = c.Int(nullable: false),
                        UrunAdi = c.String(),
                        Aciklama = c.String(),
                        EklenmeTarihi = c.DateTime(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        UrunFiyati = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Kdv = c.Int(nullable: false),
                        StokMiktari = c.Int(nullable: false),
                        ToptanFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Kategori", t => t.KategoriId, cascadeDelete: true)
                .ForeignKey("dbo.Marka", t => t.MarkaId, cascadeDelete: true)
                .Index(t => t.KategoriId)
                .Index(t => t.MarkaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Siparis", "UrunId", "dbo.Urun");
            DropForeignKey("dbo.Urun", "MarkaId", "dbo.Marka");
            DropForeignKey("dbo.Urun", "KategoriId", "dbo.Kategori");
            DropForeignKey("dbo.Siparis", "MusteriId", "dbo.Musteri");
            DropIndex("dbo.Urun", new[] { "MarkaId" });
            DropIndex("dbo.Urun", new[] { "KategoriId" });
            DropIndex("dbo.Siparis", new[] { "UrunId" });
            DropIndex("dbo.Siparis", new[] { "MusteriId" });
            DropTable("dbo.Urun");
            DropTable("dbo.Siparis");
            DropTable("dbo.Musteri");
            DropTable("dbo.Marka");
            DropTable("dbo.Kullanici");
            DropTable("dbo.Kategori");
        }
    }
}
