namespace sb_admin_2.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MdvrSerialNoRemovedFromNewTaxi : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NewTaxis", "NT_MDVRSerialNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NewTaxis", "NT_MDVRSerialNo", c => c.String(nullable: false));
        }
    }
}
