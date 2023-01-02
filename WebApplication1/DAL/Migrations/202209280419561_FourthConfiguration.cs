namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FourthConfiguration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Single(nullable: false),
                        qty = c.Int(nullable: false),
                        prodID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Products", t => t.prodID, cascadeDelete: true)
                .Index(t => t.prodID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "prodID", "dbo.Products");
            DropIndex("dbo.Purchases", new[] { "prodID" });
            DropTable("dbo.Purchases");
        }
    }
}
