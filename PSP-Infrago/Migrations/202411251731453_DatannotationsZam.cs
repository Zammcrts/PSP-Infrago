namespace PSP_Infrago.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatannotationsZam : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(maxLength: 100));
            AlterColumn("dbo.MaterialAssignments", "Project", c => c.String(maxLength: 100));
            AlterColumn("dbo.MaterialAssignments", "Material", c => c.String(maxLength: 100));
            AlterColumn("dbo.MaterialAssignments", "Quantity", c => c.Single(nullable: false));
            AlterColumn("dbo.Materials", "MaterialName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Materials", "QuantityInStock", c => c.String(maxLength: 100));
            AlterColumn("dbo.OrderDetails", "Order", c => c.String(maxLength: 50));
            AlterColumn("dbo.OrderDetails", "Material", c => c.String(maxLength: 100));
            AlterColumn("dbo.Orders", "Provider", c => c.String(maxLength: 100));
            AlterColumn("dbo.Orders", "Department", c => c.String(maxLength: 100));
            AlterColumn("dbo.Projects", "Client", c => c.String(maxLength: 200));
            AlterColumn("dbo.Projects", "ProjectName", c => c.String(maxLength: 150));
            AlterColumn("dbo.Projects", "Status", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Status", c => c.String(nullable: false));
            AlterColumn("dbo.Projects", "ProjectName", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.Projects", "Client", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Orders", "Department", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Orders", "Provider", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.OrderDetails", "Material", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.OrderDetails", "Order", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Materials", "QuantityInStock", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Materials", "MaterialName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.MaterialAssignments", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.MaterialAssignments", "Material", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.MaterialAssignments", "Project", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
