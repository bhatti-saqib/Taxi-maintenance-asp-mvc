namespace sb_admin_2.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PlateNumberBecomesPrimaryKey : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.NewTaxis");
            AlterColumn("dbo.NewTaxis", "NT_PlateNumber", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.NewTaxis", "NT_PlateNumber");
            DropColumn("dbo.NewTaxis", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NewTaxis", "Id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.NewTaxis");
            AlterColumn("dbo.NewTaxis", "NT_PlateNumber", c => c.String(nullable: false));
            AddPrimaryKey("dbo.NewTaxis", "Id");
        }
    }
}
