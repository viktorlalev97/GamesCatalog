namespace GamesCatalog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GamesCatalog : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "ImgURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "ImgURL");
        }
    }
}
