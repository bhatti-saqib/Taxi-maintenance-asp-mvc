namespace sb_admin_2.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeRepsNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NewTaxis", "Is_NT_DepotRepApproved", c => c.Boolean());
            AlterColumn("dbo.NewTaxis", "Is_NT_SecureTechRepApproved", c => c.Boolean());
            AlterColumn("dbo.NewTaxis", "Is_NT_MccRepApproved", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NewTaxis", "Is_NT_MccRepApproved", c => c.Boolean(nullable: false));
            AlterColumn("dbo.NewTaxis", "Is_NT_SecureTechRepApproved", c => c.Boolean(nullable: false));
            AlterColumn("dbo.NewTaxis", "Is_NT_DepotRepApproved", c => c.Boolean(nullable: false));
        }
    }
}
