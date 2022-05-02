namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteri", "Adres", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musteri", "Adres");
        }
    }
}
