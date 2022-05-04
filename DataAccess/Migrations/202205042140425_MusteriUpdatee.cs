namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MusteriUpdatee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteri", "AktifMi", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musteri", "AktifMi");
        }
    }
}
