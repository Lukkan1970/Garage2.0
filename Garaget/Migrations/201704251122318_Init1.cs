namespace Garaget.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParkedVehicles", "RegNo", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.ParkedVehicles", "Color", c => c.String(nullable: false));
            AlterColumn("dbo.ParkedVehicles", "Make", c => c.String(nullable: false));
            AlterColumn("dbo.ParkedVehicles", "Model", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkedVehicles", "Model", c => c.String());
            AlterColumn("dbo.ParkedVehicles", "Make", c => c.String());
            AlterColumn("dbo.ParkedVehicles", "Color", c => c.String());
            AlterColumn("dbo.ParkedVehicles", "RegNo", c => c.String());
        }
    }
}
