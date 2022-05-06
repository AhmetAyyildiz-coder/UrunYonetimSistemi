namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UrunYonetim.Entites;
    internal sealed class Configuration : DbMigrationsConfiguration<UrunYonetim.DataAccess.ModelDb>
    {
        public Configuration()
        {
            ContextKey = "UrunYonetim.DataAccess.ModelDb";
        }

        protected override void Seed(UrunYonetim.DataAccess.ModelDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            /*
             * Migration ger�ekle�tikten sonra yap�labileceklerimizi buraya yazabiliriz.
             */

            if (!context.Kullanicilar.Any())
            {
                context.Kullanicilar.Add(new Kullanici
                {
                    Ad = "Ahmet",
                    Email = "ahmetayyildiz.dev@gmail.com",
                    kullaniciAdi = "admin",
                    AktifMi = true,
                    sifre = "1234",
                    Soyad = "Ayyildiz"
                });
                context.SaveChanges();
            }
            base.Seed(context);
        }
    }
}
