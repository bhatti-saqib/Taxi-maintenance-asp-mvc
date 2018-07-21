namespace sb_admin_2.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToNewTaxi : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.NewTaxis", "NT_TaxiType", c => c.String(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_Region", c => c.String(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_ExistingMDVR", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_Cameras", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_Ups", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_Hdds", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_Sims", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_Emmis", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_CameraFovs", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_PowerConnections", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_PowerCables", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_CameraCables", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_FourG_cables", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_Gps_cables", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_WifiCables", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_Labeling", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_CableDressing", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_CameraConnector", c => c.String(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_DiskSize", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_BroncoMdvrs", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_Gps", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_Four_g", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_Wifi", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_VoltageTest", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_Channel", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_TaxiHandover", c => c.Int(nullable: false));
            AlterColumn("dbo.NewTaxis", "NT_NoExistingAlarms", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NewTaxis", "NT_NoExistingAlarms", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_TaxiHandover", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_Channel", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_VoltageTest", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_Wifi", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_Four_g", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_Gps", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_BroncoMdvrs", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_DiskSize", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_CameraConnector", c => c.String());
            AlterColumn("dbo.NewTaxis", "NT_CableDressing", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_Labeling", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_WifiCables", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_Gps_cables", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_FourG_cables", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_CameraCables", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_PowerCables", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_PowerConnections", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_CameraFovs", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_Emmis", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_Sims", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_Hdds", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_Ups", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_Cameras", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_ExistingMDVR", c => c.Int());
            AlterColumn("dbo.NewTaxis", "NT_Region", c => c.String());
            AlterColumn("dbo.NewTaxis", "NT_TaxiType", c => c.String());
        }
    }
}
