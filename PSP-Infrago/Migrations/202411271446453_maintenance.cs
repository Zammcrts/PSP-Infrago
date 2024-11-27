namespace PSP_Infrago.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class maintenance : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MaintenanceDetails", "MaintenanceDate", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MaintenanceDetails", "MaintenanceDate", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
