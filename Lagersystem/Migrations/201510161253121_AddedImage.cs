namespace Lagersystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "PictureURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "PictureURL");
        }
    }
}
