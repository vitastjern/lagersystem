namespace Lagersystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ModifiedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ModifiedDate");
        }
    }
}
