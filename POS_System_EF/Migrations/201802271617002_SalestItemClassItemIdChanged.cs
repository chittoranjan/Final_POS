namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalestItemClassItemIdChanged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SalesItems", "ItemId", "dbo.Items");
            DropIndex("dbo.SalesItems", new[] { "ItemId" });
            AlterColumn("dbo.SalesItems", "ItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.SalesItems", "ItemId");
            AddForeignKey("dbo.SalesItems", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SalesItems", "ItemId", "dbo.Items");
            DropIndex("dbo.SalesItems", new[] { "ItemId" });
            AlterColumn("dbo.SalesItems", "ItemId", c => c.Int());
            CreateIndex("dbo.SalesItems", "ItemId");
            AddForeignKey("dbo.SalesItems", "ItemId", "dbo.Items", "Id");
        }
    }
}
