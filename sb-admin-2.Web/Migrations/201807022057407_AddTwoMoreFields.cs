namespace sb_admin_2.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTwoMoreFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NewTaxis", "NT_TaxiCabin", c => c.String(nullable: false));
            AddColumn("dbo.NewTaxis", "NT_ItemsLeftInside", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.NewTaxis", "NT_ItemsLeftInside");
            DropColumn("dbo.NewTaxis", "NT_TaxiCabin");
        }
    }
}
