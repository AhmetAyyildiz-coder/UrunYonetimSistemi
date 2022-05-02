namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

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
        }
    }
}
