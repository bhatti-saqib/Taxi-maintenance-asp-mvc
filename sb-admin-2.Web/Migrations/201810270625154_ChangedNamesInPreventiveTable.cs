namespace sb_admin_2.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedNamesInPreventiveTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Preventives", "MT_ReplacedMDVRSerialNo", c => c.String());
            AddColumn("dbo.Preventives", "MT_ReplacedCameraSerialNo", c => c.String());
            AddColumn("dbo.Preventives", "MT_ReplacedUpsSerialNo", c => c.String());
            AddColumn("dbo.Preventives", "MT_ReplacedHDDSerialNo", c => c.String());
            DropColumn("dbo.Preventives", "MT_MDVRSerialNo");
            DropColumn("dbo.Preventives", "MT_CameraSerialNo");
            DropColumn("dbo.Preventives", "MT_UpsSerialNo");
            DropColumn("dbo.Preventives", "MT_HDDSerialNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Preventives", "MT_HDDSerialNo", c => c.String());
            AddColumn("dbo.Preventives", "MT_UpsSerialNo", c => c.String());
            AddColumn("dbo.Preventives", "MT_CameraSerialNo", c => c.String());
            AddColumn("dbo.Preventives", "MT_MDVRSerialNo", c => c.String());
            DropColumn("dbo.Preventives", "MT_ReplacedHDDSerialNo");
            DropColumn("dbo.Preventives", "MT_ReplacedUpsSerialNo");
            DropColumn("dbo.Preventives", "MT_ReplacedCameraSerialNo");
            DropColumn("dbo.Preventives", "MT_ReplacedMDVRSerialNo");
        }
    }
}
