namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FifthConfiguration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        pid = c.Int(nullable: false),
                        categId = c.Int(nullable: false),
                        qty = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categories", t => t.categId, cascadeDelete: false)
                .ForeignKey("dbo.Products", t => t.pid, cascadeDelete: false)
                .Index(t => t.pid)
                .Index(t => t.categId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inventories", "pid", "dbo.Products");
            DropForeignKey("dbo.Inventories", "categId", "dbo.Categories");
            DropIndex("dbo.Inventories", new[] { "categId" });
            DropIndex("dbo.Inventories", new[] { "pid" });
            DropTable("dbo.Inventories");
        }
    }
}
