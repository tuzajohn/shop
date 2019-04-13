namespace SwiftShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inventory_table_compareatprice_rename_cost_to_prica_in_product : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventory",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Product", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Product", "CompareAtPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Share", "StarNumber", c => c.Int(nullable: false));
            DropColumn("dbo.Product", "Cost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "Cost", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Share", "StarNumber", c => c.String());
            DropColumn("dbo.Product", "CompareAtPrice");
            DropColumn("dbo.Product", "Price");
            DropTable("dbo.Inventory");
        }
    }
}
