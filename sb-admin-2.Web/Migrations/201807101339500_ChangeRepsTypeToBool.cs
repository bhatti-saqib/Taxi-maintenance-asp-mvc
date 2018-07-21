namespace sb_admin_2.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRepsTypeToBool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewTaxis", "Is_NT_DepotRepApproved", c => c.Boolean(nullable: true));
            AddColumn("dbo.NewTaxis", "Is_NT_SecureTechRepApproved", c => c.Boolean(nullable: true));
            AddColumn("dbo.NewTaxis", "Is_NT_MccRepApproved", c => c.Boolean(nullable: true));
            DropColumn("dbo.NewTaxis", "NT_DepotRepresentative");
            DropColumn("dbo.NewTaxis", "NT_SecureTechRepresentative");
            DropColumn("dbo.NewTaxis", "NT_MccRepresentative");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NewTaxis", "NT_MccRepresentative", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_SecureTechRepresentative", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_DepotRepresentative", c => c.String(nullable: false));
            DropColumn("dbo.NewTaxis", "Is_NT_MccRepApproved");
            DropColumn("dbo.NewTaxis", "Is_NT_SecureTechRepApproved");
            DropColumn("dbo.NewTaxis", "Is_NT_DepotRepApproved");
        }
    }
}
