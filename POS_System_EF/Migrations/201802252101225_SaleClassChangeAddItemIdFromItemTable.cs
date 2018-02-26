namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SaleClassChangeAddItemIdFromItemTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SalesItems", "ItemId", c => c.Int());
            CreateIndex("dbo.SalesItems", "ItemId");
            AddForeignKey("dbo.SalesItems", "ItemId", "dbo.Items", "Id");
            DropColumn("dbo.SalesItems", "SalesItemName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SalesItems", "SalesItemName", c => c.String());
            DropForeignKey("dbo.SalesItems", "ItemId", "dbo.Items");
            DropIndex("dbo.SalesItems", new[] { "ItemId" });
            DropColumn("dbo.SalesItems", "ItemId");
        }
    }
}
