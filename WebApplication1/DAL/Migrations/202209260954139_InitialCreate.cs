namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        photoPath = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        categID = c.Int(nullable: false),
                        photoPath = c.String(),
                        price = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categories", t => t.categID, cascadeDelete: true)
                .Index(t => t.categID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "categID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "categID" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
