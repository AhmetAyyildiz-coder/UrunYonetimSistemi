namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MusteriUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteri", "EklenmeTarihi", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musteri", "EklenmeTarihi");
        }
    }
}
