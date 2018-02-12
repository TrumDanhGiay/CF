namespace CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Trang1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Status2", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Status2");
        }
    }
}
