namespace sb_admin_2.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SerialNumberRemovedFromEquipment : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NewTaxis", "NT_MDVRSerialNo");
            DropColumn("dbo.NewTaxis", "NT_CameraSerialNo");
            DropColumn("dbo.NewTaxis", "NT_UpsSerialNo");
            DropColumn("dbo.NewTaxis", "NT_HDDSerialNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NewTaxis", "NT_HDDSerialNo", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_UpsSerialNo", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_CameraSerialNo", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_MDVRSerialNo", c => c.String());
        }
    }
}
