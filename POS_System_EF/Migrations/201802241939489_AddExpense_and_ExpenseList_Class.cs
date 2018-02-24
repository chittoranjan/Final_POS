namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExpense_and_ExpenseList_Class : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Expenses", "ExpenseItemId", "dbo.ExpenseItems");
            DropIndex("dbo.Expenses", new[] { "ExpenseItemId" });
            CreateTable(
                "dbo.ExpenseLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExpenseName = c.String(nullable: false, maxLength: 250),
                        Qty = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Paid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Due = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExpenseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Expenses", t => t.ExpenseId, cascadeDelete: false)
                .Index(t => t.ExpenseId);
            
            AddColumn("dbo.Expenses", "InvoiceNo", c => c.String());
            AddColumn("dbo.Expenses", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.Expenses", "ExpenseName");
            DropColumn("dbo.Expenses", "Qty");
            DropColumn("dbo.Expenses", "Amount");
            DropColumn("dbo.Expenses", "Paid");
            DropColumn("dbo.Expenses", "Due");
            DropColumn("dbo.Expenses", "ExpenseItemId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Expenses", "ExpenseItemId", c => c.Int(nullable: false));
            AddColumn("dbo.Expenses", "Due", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Expenses", "Paid", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Expenses", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Expenses", "Qty", c => c.Int(nullable: false));
            AddColumn("dbo.Expenses", "ExpenseName", c => c.String(nullable: false, maxLength: 150));
            DropForeignKey("dbo.ExpenseLists", "ExpenseId", "dbo.Expenses");
            DropIndex("dbo.ExpenseLists", new[] { "ExpenseId" });
            DropColumn("dbo.Expenses", "TotalAmount");
            DropColumn("dbo.Expenses", "InvoiceNo");
            DropTable("dbo.ExpenseLists");
            CreateIndex("dbo.Expenses", "ExpenseItemId");
            AddForeignKey("dbo.Expenses", "ExpenseItemId", "dbo.ExpenseItems", "Id", cascadeDelete: false);
        }
    }
}
