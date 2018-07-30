namespace sb_admin_2.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PicsFieldsAddedToNewTaxi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewTaxis", "NT_PlateNumberPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_MdvrNoPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_MDVRSerialNoPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_CameraSerialNoPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_UpsSerialNoPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_HDDSerialNoPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_PowerConnectionsPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_PowerCablesPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_CameraCablesPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_FourG_cablesPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_Gps_cablesPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_WifiCablesPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_LabelingPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_CableDressingPic", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewTaxis", "NT_CableDressingPic");
            DropColumn("dbo.NewTaxis", "NT_LabelingPic");
            DropColumn("dbo.NewTaxis", "NT_WifiCablesPic");
            DropColumn("dbo.NewTaxis", "NT_Gps_cablesPic");
            DropColumn("dbo.NewTaxis", "NT_FourG_cablesPic");
            DropColumn("dbo.NewTaxis", "NT_CameraCablesPic");
            DropColumn("dbo.NewTaxis", "NT_PowerCablesPic");
            DropColumn("dbo.NewTaxis", "NT_PowerConnectionsPic");
            DropColumn("dbo.NewTaxis", "NT_HDDSerialNoPic");
            DropColumn("dbo.NewTaxis", "NT_UpsSerialNoPic");
            DropColumn("dbo.NewTaxis", "NT_CameraSerialNoPic");
            DropColumn("dbo.NewTaxis", "NT_MDVRSerialNoPic");
            DropColumn("dbo.NewTaxis", "NT_MdvrNoPic");
            DropColumn("dbo.NewTaxis", "NT_PlateNumberPic");
        }
    }
}
