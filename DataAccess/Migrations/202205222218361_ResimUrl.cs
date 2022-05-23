namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResimUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urun", "ResimUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Urun", "ResimUrl");
        }
    }
}
