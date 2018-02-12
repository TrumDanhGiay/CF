namespace CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Trang : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Status");
        }
    }
}
