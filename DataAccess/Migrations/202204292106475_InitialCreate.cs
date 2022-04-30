namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
                    })
                .PrimaryKey(t => t.id);
            
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
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Urun");
            DropTable("dbo.Musteri");
            DropTable("dbo.Marka");
            DropTable("dbo.Kullanici");
            DropTable("dbo.Kategori");
        }
    }
}
