namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalesClassChanged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Sales", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Sales", new[] { "CustomerId" });
            AddColumn("dbo.Sales", "Remarks", c => c.String());
            AddColumn("dbo.Sales", "CustomerContactNo", c => c.String());
            AddColumn("dbo.Sales", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.SalesItems", "LineTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.SalesItems", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Sales", "Total");
            DropColumn("dbo.Sales", "SalesDate");
            DropColumn("dbo.Sales", "ContactNo");
            DropColumn("dbo.Sales", "CustomerId");
            DropColumn("dbo.Sales", "IsDelete");
            DropColumn("dbo.SalesItems", "LineTotalPrice");
            DropColumn("dbo.SalesItems", "TotalPrice");
            DropColumn("dbo.SalesItems", "IsDelete");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SalesItems", "IsDelete", c => c.Boolean(nullable: false));
            AddColumn("dbo.SalesItems", "TotalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.SalesItems", "LineTotalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Sales", "IsDelete", c => c.Boolean(nullable: false));
            AddColumn("dbo.Sales", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Sales", "ContactNo", c => c.String());
            AddColumn("dbo.Sales", "SalesDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Sales", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.SalesItems", "Total");
            DropColumn("dbo.SalesItems", "LineTotal");
            DropColumn("dbo.Sales", "TotalAmount");
            DropColumn("dbo.Sales", "CustomerContactNo");
            DropColumn("dbo.Sales", "Remarks");
            CreateIndex("dbo.Sales", "CustomerId");
            AddForeignKey("dbo.Sales", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
