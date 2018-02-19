namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PurchaseClassAddedTotalAmountField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Purchases", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Purchases", "TotalAmount");
        }
    }
}
