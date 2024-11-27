namespace PSP_Infrago.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class toolassignment : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ToolAssignments", "Date", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ToolAssignments", "Date", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
