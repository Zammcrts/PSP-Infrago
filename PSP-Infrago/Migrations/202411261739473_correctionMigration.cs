namespace PSP_Infrago.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correctionMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Machineries", "Photo", c => c.String());
            AddColumn("dbo.MachineryAssignments", "Photo", c => c.String());
            AddColumn("dbo.MaintenanceDetails", "Photo", c => c.String());
            AddColumn("dbo.Maintenances", "Photo", c => c.String());
            AddColumn("dbo.ProjectDetails", "Photo", c => c.String());
            AddColumn("dbo.ToolAssignments", "Photo", c => c.String());
            AddColumn("dbo.Tools", "Photo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tools", "Photo");
            DropColumn("dbo.ToolAssignments", "Photo");
            DropColumn("dbo.ProjectDetails", "Photo");
            DropColumn("dbo.Maintenances", "Photo");
            DropColumn("dbo.MaintenanceDetails", "Photo");
            DropColumn("dbo.MachineryAssignments", "Photo");
            DropColumn("dbo.Machineries", "Photo");
        }
    }
}
