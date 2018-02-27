namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tempPurchaseClassChanged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TempPurchases", "ItemId", "dbo.Items");
            DropIndex("dbo.TempPurchases", new[] { "ItemId" });
            AddColumn("dbo.TempPurchases", "ItemId", c => c.Int());
            CreateIndex("dbo.TempPurchases", "ItemId");
            AddForeignKey("dbo.TempPurchases", "ItemId", "dbo.Items", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TempPurchases", "ItemId", "dbo.Items");
            DropIndex("dbo.TempPurchases", new[] { "ItemId" });
            AlterColumn("dbo.TempPurchases", "ItemId", c => c.Int(nullable: false));
            CreateIndex("dbo.TempPurchases", "ItemId");
            AddForeignKey("dbo.TempPurchases", "ItemId", "dbo.Items", "Id", cascadeDelete: false);
        }
    }
}
