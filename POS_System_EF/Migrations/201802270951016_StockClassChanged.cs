namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StockClassChanged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TempPurchases", "ItemId", "dbo.Items");
            DropIndex("dbo.TempPurchases", new[] { "ItemId" });
            AddColumn("dbo.Stocks", "ItemName", c => c.String());
            AddColumn("dbo.Stocks", "AveragePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TempPurchases", "ItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.TempPurchases", "ItemId");
            AddForeignKey("dbo.TempPurchases", "ItemId", "dbo.Items", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TempPurchases", "ItemId", "dbo.Items");
            DropIndex("dbo.TempPurchases", new[] { "ItemId" });
            AlterColumn("dbo.TempPurchases", "ItemId", c => c.Int());
            DropColumn("dbo.Stocks", "AveragePrice");
            DropColumn("dbo.Stocks", "ItemName");
            CreateIndex("dbo.TempPurchases", "ItemId");
            AddForeignKey("dbo.TempPurchases", "ItemId", "dbo.Items", "Id");
        }
    }
}
