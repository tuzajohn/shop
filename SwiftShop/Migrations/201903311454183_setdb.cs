namespace SwiftShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AlternateProduct",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Buyer",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cart",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        BuyerId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Date = c.DateTime(),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        LinkId = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PRoductImage",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Path = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        BuyerId = c.Int(nullable: false),
                        SellerId = c.Int(nullable: false),
                        Date = c.DateTime(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        SellerId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        ImageId = c.Int(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        Name = c.String(),
                        Date = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Promotion",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Caption = c.String(),
                        Date = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Share",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Comment = c.String(),
                        StarNumber = c.String(),
                        Date = c.DateTime(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Contact = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
            DropTable("dbo.Share");
            DropTable("dbo.Promotion");
            DropTable("dbo.Product");
            DropTable("dbo.Order");
            DropTable("dbo.PRoductImage");
            DropTable("dbo.Category");
            DropTable("dbo.Cart");
            DropTable("dbo.Buyer");
            DropTable("dbo.AlternateProduct");
        }
    }
}
