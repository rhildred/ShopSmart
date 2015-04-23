namespace ShopSmart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Place_id", c => c.Int());
            AddColumn("dbo.People", "Place_id", c => c.Int());
            AddForeignKey("dbo.Products", "Place_id", "dbo.Places", "id");
            AddForeignKey("dbo.People", "Place_id", "dbo.Places", "id");
            CreateIndex("dbo.Products", "Place_id");
            CreateIndex("dbo.People", "Place_id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.People", new[] { "Place_id" });
            DropIndex("dbo.Products", new[] { "Place_id" });
            DropForeignKey("dbo.People", "Place_id", "dbo.Places");
            DropForeignKey("dbo.Products", "Place_id", "dbo.Places");
            DropColumn("dbo.People", "Place_id");
            DropColumn("dbo.Products", "Place_id");
        }
    }
}
