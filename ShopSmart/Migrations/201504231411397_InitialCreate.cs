namespace ShopSmart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        gtin13 = c.String(),
                        sku = c.String(),
                        name = c.String(),
                        image = c.String(),
                        description = c.String(),
                        brand = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
            DropTable("dbo.Products");
        }
    }
}
