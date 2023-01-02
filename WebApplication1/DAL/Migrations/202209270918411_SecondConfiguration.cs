namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondConfiguration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "check", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "check");
        }
    }
}
