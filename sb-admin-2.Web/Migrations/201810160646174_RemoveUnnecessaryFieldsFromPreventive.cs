namespace sb_admin_2.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUnnecessaryFieldsFromPreventive : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Preventives", "MT_SiteName");
            DropColumn("dbo.Preventives", "MT_TaxiType");
            DropColumn("dbo.Preventives", "MT_MdvrNo");
            DropColumn("dbo.Preventives", "MT_Region");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Preventives", "MT_Region", c => c.String(nullable: false));
            AddColumn("dbo.Preventives", "MT_MdvrNo", c => c.String(nullable: false));
            AddColumn("dbo.Preventives", "MT_TaxiType", c => c.String(nullable: false));
            AddColumn("dbo.Preventives", "MT_SiteName", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
