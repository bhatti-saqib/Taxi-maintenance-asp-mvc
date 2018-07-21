namespace sb_admin_2.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewTaxis",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NT_Sites = c.Int(),
                        NT_SiteName = c.String(nullable: false, maxLength: 255),
                        NT_TaxiType = c.String(),
                        NT_PlateNumber = c.String(nullable: false),
                        NT_MdvrNo = c.String(nullable: false),
                        NT_Date = c.DateTime(nullable: false),
                        NT_Region = c.String(),
                        NT_ExistingMDVR = c.Int(),
                        NT_MDVRSerialNo = c.String(),
                        NT_Cameras = c.Int(),
                        NT_CameraSerialNo = c.String(),
                        NT_Ups = c.Int(),
                        NT_UpsSerialNo = c.String(),
                        NT_Hdds = c.Int(),
                        NT_HDDSerialNo = c.String(),
                        NT_Sims = c.Int(),
                        NT_Emmis = c.Int(),
                        NT_CameraFovs = c.Int(),
                        NT_PowerConnections = c.Int(),
                        NT_PowerCables = c.Int(),
                        NT_CameraCables = c.Int(),
                        NT_FourG_cables = c.Int(),
                        NT_Gps_cables = c.Int(),
                        NT_WifiCables = c.Int(),
                        NT_Labeling = c.Int(),
                        NT_CableDressing = c.Int(),
                        NT_CameraConnector = c.String(),
                        NT_DiskSize = c.Int(),
                        NT_BroncoMdvrs = c.Int(),
                        NT_Gps = c.Int(),
                        NT_Four_g = c.Int(),
                        NT_Wifi = c.Int(),
                        NT_VoltageTest = c.Int(),
                        NT_Channel = c.Int(),
                        NT_TaxiHandover = c.Int(),
                        NT_NoExistingAlarms = c.Int(),
                        NT_DepotRepresentative = c.String(nullable: false),
                        NT_SecureTechRepresentative = c.String(nullable: false),
                        NT_MccRepresentative = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NewTaxis");
        }
    }
}
