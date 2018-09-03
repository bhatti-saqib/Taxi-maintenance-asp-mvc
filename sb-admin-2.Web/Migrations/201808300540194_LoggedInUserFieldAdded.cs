namespace sb_admin_2.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoggedInUserFieldAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewTaxis", "User", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewTaxis", "User");
        }
    }
}
