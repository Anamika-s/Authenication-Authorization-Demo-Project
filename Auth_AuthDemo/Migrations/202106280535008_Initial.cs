namespace Auth_AuthDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        QtyStock = c.Int(nullable: false),
                        DateOfPurchase = c.DateTime(nullable: false),
                        Supplier_SupplierId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_SupplierId)
                .Index(t => t.Supplier_SupplierId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                        State = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SupplierId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Supplier_SupplierId", "dbo.Suppliers");
            DropIndex("dbo.Products", new[] { "Supplier_SupplierId" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Products");
        }
    }
}
