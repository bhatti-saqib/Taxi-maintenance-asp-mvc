namespace sb_admin_2.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSerialNumbersFieldsInEquipment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewTaxis", "NT_MDVRSerialNo", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_CameraSerialNo", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_UpsSerialNo", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_HDDSerialNo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewTaxis", "NT_HDDSerialNo");
            DropColumn("dbo.NewTaxis", "NT_UpsSerialNo");
            DropColumn("dbo.NewTaxis", "NT_CameraSerialNo");
            DropColumn("dbo.NewTaxis", "NT_MDVRSerialNo");
        }
    }
}
