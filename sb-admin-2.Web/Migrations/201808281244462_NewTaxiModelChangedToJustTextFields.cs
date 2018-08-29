namespace sb_admin_2.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTaxiModelChangedToJustTextFields : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NewTaxis", "NT_ExistingMDVR");
            DropColumn("dbo.NewTaxis", "NT_Cameras");
            DropColumn("dbo.NewTaxis", "NT_Ups");
            DropColumn("dbo.NewTaxis", "NT_Hdds");
            DropColumn("dbo.NewTaxis", "NT_Sims");
            DropColumn("dbo.NewTaxis", "NT_CameraFovs");
            DropColumn("dbo.NewTaxis", "NT_PowerConnections");
            DropColumn("dbo.NewTaxis", "NT_PowerCables");
            DropColumn("dbo.NewTaxis", "NT_CameraCables");
            DropColumn("dbo.NewTaxis", "NT_FourG_cables");
            DropColumn("dbo.NewTaxis", "NT_Gps_cables");
            DropColumn("dbo.NewTaxis", "NT_WifiCables");
            DropColumn("dbo.NewTaxis", "NT_Labeling");
            DropColumn("dbo.NewTaxis", "NT_CableDressing");
            DropColumn("dbo.NewTaxis", "NT_BroncoMdvrs");
            DropColumn("dbo.NewTaxis", "NT_Gps");
            DropColumn("dbo.NewTaxis", "NT_Four_g");
            DropColumn("dbo.NewTaxis", "NT_Wifi");
            DropColumn("dbo.NewTaxis", "NT_VoltageTest");
            DropColumn("dbo.NewTaxis", "NT_Channel");
            DropColumn("dbo.NewTaxis", "NT_TaxiHandover");
            DropColumn("dbo.NewTaxis", "NT_NoExistingAlarms");
            DropColumn("dbo.NewTaxis", "NT_TaxiCabin");
            DropColumn("dbo.NewTaxis", "NT_ItemsLeftInside");
            DropColumn("dbo.NewTaxis", "NT_PlateNumberPic");
            DropColumn("dbo.NewTaxis", "NT_MdvrNoPic");
            DropColumn("dbo.NewTaxis", "NT_MDVRSerialNoPic");
            DropColumn("dbo.NewTaxis", "NT_CameraSerialNoPic");
            DropColumn("dbo.NewTaxis", "NT_UpsSerialNoPic");
            DropColumn("dbo.NewTaxis", "NT_HDDSerialNoPic");
            DropColumn("dbo.NewTaxis", "NT_PowerConnectionsPic");
            DropColumn("dbo.NewTaxis", "NT_PowerCablesPic");
            DropColumn("dbo.NewTaxis", "NT_CameraCablesPic");
            DropColumn("dbo.NewTaxis", "NT_FourG_cablesPic");
            DropColumn("dbo.NewTaxis", "NT_Gps_cablesPic");
            DropColumn("dbo.NewTaxis", "NT_WifiCablesPic");
            DropColumn("dbo.NewTaxis", "NT_LabelingPic");
            DropColumn("dbo.NewTaxis", "NT_CableDressingPic");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NewTaxis", "NT_CableDressingPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_LabelingPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_WifiCablesPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_Gps_cablesPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_FourG_cablesPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_CameraCablesPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_PowerCablesPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_PowerConnectionsPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_HDDSerialNoPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_UpsSerialNoPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_CameraSerialNoPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_MDVRSerialNoPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_MdvrNoPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_PlateNumberPic", c => c.String());
            AddColumn("dbo.NewTaxis", "NT_ItemsLeftInside", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_TaxiCabin", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_NoExistingAlarms", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_TaxiHandover", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_Channel", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_VoltageTest", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_Wifi", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_Four_g", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_Gps", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_BroncoMdvrs", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_CableDressing", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_Labeling", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_WifiCables", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_Gps_cables", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_FourG_cables", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_CameraCables", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_PowerCables", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_PowerConnections", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_CameraFovs", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_Sims", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_Hdds", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_Ups", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_Cameras", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_ExistingMDVR", c => c.String(nullable: false));
        }
    }
}
