namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SiparisTablosuEkleme : DbMigration
    {
        public override void Up()
        {
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
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Siparis");
        }
    }
}
