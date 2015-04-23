namespace ShopSmart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Places : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        formatted_address = c.String(),
                        formatted_phone_number = c.String(),
                        image = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Places");
        }
    }
}
