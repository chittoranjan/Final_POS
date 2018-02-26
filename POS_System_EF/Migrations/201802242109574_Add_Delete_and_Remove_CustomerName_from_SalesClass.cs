namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Delete_and_Remove_CustomerName_from_SalesClass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TempPurchases", "IsDelete", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sales", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Sales", "SalesDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Sales", "IsDelete", c => c.Boolean(nullable: false));
            CreateIndex("dbo.Sales", "CustomerId");
            AddForeignKey("dbo.Sales", "CustomerId", "dbo.Customers", "Id", cascadeDelete: false);
            DropColumn("dbo.Sales", "CustomerName");
            DropColumn("dbo.Sales", "CustomerContactNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "CustomerContactNo", c => c.String());
            AddColumn("dbo.Sales", "CustomerName", c => c.String());
            DropForeignKey("dbo.Sales", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Sales", new[] { "CustomerId" });
            DropColumn("dbo.Sales", "IsDelete");
            DropColumn("dbo.Sales", "SalesDate");
            DropColumn("dbo.Sales", "CustomerId");
            DropColumn("dbo.TempPurchases", "IsDelete");
        }
    }
}
