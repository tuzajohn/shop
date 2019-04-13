namespace SwiftShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class support_image : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SupportImages",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ImageId = c.Int(nullable: false),
                        Path = c.String(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SupportImages");
        }
    }
}
