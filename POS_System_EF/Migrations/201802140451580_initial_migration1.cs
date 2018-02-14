namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 12),
                        ContactNo = c.String(nullable: false, maxLength: 11),
                        Email = c.String(),
                        Address = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        ContactNo = c.String(nullable: false, maxLength: 11),
                        JoiningDate = c.DateTime(nullable: false),
                        Code = c.String(nullable: false, maxLength: 12),
                        Image = c.Binary(nullable: false),
                        EmergencyContactNo = c.String(),
                        FathersName = c.String(nullable: false, maxLength: 50),
                        MothersName = c.String(nullable: false, maxLength: 50),
                        NID = c.String(nullable: false, maxLength: 17),
                        Reference = c.String(),
                        PresentAddress = c.String(nullable: false, maxLength: 250),
                        PermanentAddress = c.String(nullable: false, maxLength: 250),
                        Email = c.String(),
                        OutletId = c.Int(),
                        OrganizationId = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: false)
                .ForeignKey("dbo.Outlets", t => t.OutletId)
                .Index(t => t.OutletId)
                .Index(t => t.OrganizationId);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 12),
                        Logo = c.Binary(),
                        Address = c.String(nullable: false, maxLength: 250),
                        ContactNo = c.String(nullable: false, maxLength: 11),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Outlets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 12),
                        Address = c.String(nullable: false, maxLength: 250),
                        ContactNo = c.String(nullable: false, maxLength: 11),
                        OrganizationId = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: false)
                .Index(t => t.OrganizationId);
            
            CreateTable(
                "dbo.ExpenseCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                        Code = c.String(nullable: false, maxLength: 12),
                        Description = c.String(),
                        RootCategoryId = c.Int(nullable: false),
                        RootCategoryName = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ExpenseItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Description = c.String(),
                        ExpenseCategoryId = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpenseCategories", t => t.ExpenseCategoryId, cascadeDelete: false)
                .Index(t => t.ExpenseCategoryId);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExpenseName = c.String(nullable: false, maxLength: 150),
                        Qty = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Paid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Due = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Date = c.DateTime(nullable: false),
                        Remarks = c.String(maxLength: 250),
                        ExpenseItemId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        OutletId = c.Int(nullable: false),
                        OrganizationId = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .ForeignKey("dbo.ExpenseItems", t => t.ExpenseItemId, cascadeDelete: false)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: false)
                .ForeignKey("dbo.Outlets", t => t.OutletId, cascadeDelete: true)
                .Index(t => t.ExpenseItemId)
                .Index(t => t.EmployeeId)
                .Index(t => t.OutletId)
                .Index(t => t.OrganizationId);
            
            CreateTable(
                "dbo.ItemCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Code = c.String(nullable: false, maxLength: 12),
                        Description = c.String(),
                        CategoryId = c.Int(),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemCategories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        CostPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Code = c.String(nullable: false),
                        Description = c.String(),
                        ItemCategoryId = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ItemCategories", t => t.ItemCategoryId, cascadeDelete: false)
                .Index(t => t.ItemCategoryId);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvoiceNo = c.Int(nullable: false),
                        PurchaseDate = c.DateTime(nullable: false),
                        Remarks = c.String(),
                        OutletId = c.Int(),
                        EmployeeId = c.Int(),
                        SupplierId = c.Int(),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .ForeignKey("dbo.Outlets", t => t.OutletId)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId)
                .Index(t => t.OutletId)
                .Index(t => t.EmployeeId)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.TempPurchases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Quantity = c.Int(nullable: false),
                        CostPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PurchaseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Purchases", t => t.PurchaseId, cascadeDelete: false)
                .Index(t => t.PurchaseId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        Code = c.String(nullable: false, maxLength: 12),
                        ContactNo = c.String(nullable: false, maxLength: 11),
                        Email = c.String(),
                        Address = c.String(nullable: false, maxLength: 250),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvoiceNo = c.String(),
                        SubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Vat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SalesDate = c.DateTime(nullable: false),
                        CustomerName = c.String(),
                        ContactNo = c.String(),
                        CustomerId = c.Int(nullable: false),
                        EmployeeId = c.Int(nullable: false),
                        OutletId = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: false)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: false)
                .ForeignKey("dbo.Outlets", t => t.OutletId, cascadeDelete: false)
                .Index(t => t.CustomerId)
                .Index(t => t.EmployeeId)
                .Index(t => t.OutletId);
            
            CreateTable(
                "dbo.SalesItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SalesItemName = c.String(),
                        Quantity = c.Int(nullable: false),
                        SalePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LineTotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SaleId = c.Int(nullable: false),
                        IsDelete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Sales", t => t.SaleId, cascadeDelete: false)
                .Index(t => t.SaleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "OutletId", "dbo.Outlets");
            DropForeignKey("dbo.SalesItems", "SaleId", "dbo.Sales");
            DropForeignKey("dbo.Sales", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Sales", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Purchases", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Purchases", "OutletId", "dbo.Outlets");
            DropForeignKey("dbo.TempPurchases", "PurchaseId", "dbo.Purchases");
            DropForeignKey("dbo.Purchases", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Items", "ItemCategoryId", "dbo.ItemCategories");
            DropForeignKey("dbo.ItemCategories", "CategoryId", "dbo.ItemCategories");
            DropForeignKey("dbo.Expenses", "OutletId", "dbo.Outlets");
            DropForeignKey("dbo.Expenses", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Expenses", "ExpenseItemId", "dbo.ExpenseItems");
            DropForeignKey("dbo.Expenses", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.ExpenseItems", "ExpenseCategoryId", "dbo.ExpenseCategories");
            DropForeignKey("dbo.Employees", "OutletId", "dbo.Outlets");
            DropForeignKey("dbo.Outlets", "OrganizationId", "dbo.Organizations");
            DropForeignKey("dbo.Employees", "OrganizationId", "dbo.Organizations");
            DropIndex("dbo.SalesItems", new[] { "SaleId" });
            DropIndex("dbo.Sales", new[] { "OutletId" });
            DropIndex("dbo.Sales", new[] { "EmployeeId" });
            DropIndex("dbo.Sales", new[] { "CustomerId" });
            DropIndex("dbo.TempPurchases", new[] { "PurchaseId" });
            DropIndex("dbo.Purchases", new[] { "SupplierId" });
            DropIndex("dbo.Purchases", new[] { "EmployeeId" });
            DropIndex("dbo.Purchases", new[] { "OutletId" });
            DropIndex("dbo.Items", new[] { "ItemCategoryId" });
            DropIndex("dbo.ItemCategories", new[] { "CategoryId" });
            DropIndex("dbo.Expenses", new[] { "OrganizationId" });
            DropIndex("dbo.Expenses", new[] { "OutletId" });
            DropIndex("dbo.Expenses", new[] { "EmployeeId" });
            DropIndex("dbo.Expenses", new[] { "ExpenseItemId" });
            DropIndex("dbo.ExpenseItems", new[] { "ExpenseCategoryId" });
            DropIndex("dbo.Outlets", new[] { "OrganizationId" });
            DropIndex("dbo.Employees", new[] { "OrganizationId" });
            DropIndex("dbo.Employees", new[] { "OutletId" });
            DropTable("dbo.SalesItems");
            DropTable("dbo.Sales");
            DropTable("dbo.Suppliers");
            DropTable("dbo.TempPurchases");
            DropTable("dbo.Purchases");
            DropTable("dbo.Items");
            DropTable("dbo.ItemCategories");
            DropTable("dbo.Expenses");
            DropTable("dbo.ExpenseItems");
            DropTable("dbo.ExpenseCategories");
            DropTable("dbo.Outlets");
            DropTable("dbo.Organizations");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
        }
    }
}
