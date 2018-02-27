namespace POS_System_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class supplier_class_remove_and_customer_class_modified : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "CustomerAndSuppliers");
            AddColumn("dbo.CustomerAndSuppliers", "Type", c => c.String());
            DropTable("dbo.Suppliers");
        }
        
        public override void Down()
        {
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
            
            DropColumn("dbo.CustomerAndSuppliers", "Type");
            RenameTable(name: "dbo.CustomerAndSuppliers", newName: "Customers");
        }
    }
}
