namespace sb_admin_2.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NewTaxis",
                c => new
                    {
                        NT_PlateNumber = c.String(nullable: false, maxLength: 128),
                        NT_SiteName = c.String(nullable: false, maxLength: 255),
                        NT_TaxiType = c.String(nullable: false),
                        NT_MdvrNo = c.String(nullable: false),
                        NT_Date = c.DateTime(nullable: false),
                        NT_Region = c.String(nullable: false),
                        NT_MDVRSerialNo = c.String(nullable: false),
                        NT_CameraSerialNo = c.String(nullable: false),
                        NT_UpsSerialNo = c.String(nullable: false),
                        NT_HDDSerialNo = c.String(nullable: false),
                        NT_Emmis = c.String(nullable: false),
                        NT_CameraConnector = c.String(nullable: false),
                        NT_DiskSize = c.String(nullable: false),
                        Is_NT_DepotRepApproved = c.Boolean(),
                        Is_NT_SecureTechRepApproved = c.Boolean(),
                        Is_NT_MccRepApproved = c.Boolean(),
                        User = c.String(),
                    })
                .PrimaryKey(t => t.NT_PlateNumber);
            
            CreateTable(
                "dbo.Preventives",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        typeOfMaintenance = c.String(maxLength: 1),
                        MT_PlateNumber = c.String(nullable: false),
                        MT_Date = c.DateTime(nullable: false),
                        MT_ExistingMDVR = c.String(),
                        MT_MDVRSerialNo = c.String(),
                        MT_Cameras = c.String(),
                        MT_CameraSerialNo = c.String(),
                        MT_Ups = c.String(),
                        MT_UpsSerialNo = c.String(),
                        MT_Hdds = c.String(),
                        MT_HDDSerialNo = c.String(),
                        MT_Sims = c.String(),
                        MT_Emmis = c.String(),
                        MT_CameraFovs = c.String(),
                        MT_PowerConnections = c.String(),
                        MT_PowerCables = c.String(),
                        MT_CameraCables = c.String(),
                        MT_FourG_cables = c.String(),
                        MT_Gps_cables = c.String(),
                        MT_WifiCables = c.String(),
                        MT_Labeling = c.String(),
                        MT_CableDressing = c.String(),
                        MT_BroncoMdvrs = c.String(),
                        MT_Gps = c.String(),
                        MT_Four_g = c.String(),
                        MT_Wifi = c.String(),
                        MT_VoltageTest = c.String(),
                        MT_TaxiHandover = c.String(),
                        MT_NoExistingAlarms = c.String(),
                        MT_OverallFeedback = c.String(),
                        MT_Equ_For_Corr_Measure = c.String(),
                        MT_Corr_Measure_Taken = c.String(),
                        MT_Comment_Box_For_Technicians = c.String(),
                        MT_Old_SerialNo_If_Replaced = c.String(),
                        MT_Old_SerialNo_If_Replaced_Pic = c.String(),
                        MT_New_SerialNo_If_Replaced = c.String(),
                        MT_New_SerialNo_If_Replaced_Pic = c.String(),
                        Is_MT_DepotRepApproved = c.Boolean(),
                        Is_MT_SecureTechRepApproved = c.Boolean(),
                        Is_MT_MccRepApproved = c.Boolean(),
                        MT_PlateNumberPic = c.String(),
                        MT_MdvrNoPic = c.String(),
                        MT_MDVRSerialNoPic = c.String(),
                        MT_CameraSerialNoPic = c.String(),
                        MT_UpsSerialNoPic = c.String(),
                        MT_HDDSerialNoPic = c.String(),
                        MT_PowerConnectionsPic = c.String(),
                        MT_PowerCablesPic = c.String(),
                        MT_CameraCablesPic = c.String(),
                        MT_FourG_cablesPic = c.String(),
                        MT_Gps_cablesPic = c.String(),
                        MT_WifiCablesPic = c.String(),
                        MT_LabelingPic = c.String(),
                        MT_CableDressingPic = c.String(),
                        NewTaxi_NT_PlateNumber = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.NewTaxis", t => t.NewTaxi_NT_PlateNumber)
                .Index(t => t.NewTaxi_NT_PlateNumber);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Preventives", "NewTaxi_NT_PlateNumber", "dbo.NewTaxis");
            DropIndex("dbo.Preventives", new[] { "NewTaxi_NT_PlateNumber" });
            DropTable("dbo.Preventives");
            DropTable("dbo.NewTaxis");
        }
    }
}
