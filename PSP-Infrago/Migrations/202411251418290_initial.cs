namespace PSP_Infrago.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 60),
                        Phone = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 200),
                        Street = c.String(nullable: false, maxLength: 100),
                        ExteriorNumber = c.String(maxLength: 10),
                        State = c.String(nullable: false, maxLength: 50),
                        Township = c.String(nullable: false, maxLength: 50),
                        City = c.String(nullable: false, maxLength: 50),
                        ZipCode = c.String(nullable: false, maxLength: 10),
                        Project = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(nullable: false, maxLength: 100),
                        Order = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Machineries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Model = c.String(),
                        Name = c.String(),
                        Capacity = c.String(),
                        Details = c.String(),
                        Assignment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MachineryAssignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Project = c.String(),
                        AssignationDate = c.String(),
                        Machine = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MaintenanceDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaintenanceDate = c.String(),
                        Descrption = c.String(),
                        Cost = c.Single(nullable: false),
                        Maintenance = c.String(),
                        Machinery = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Maintenances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EquipmentId = c.Int(nullable: false),
                        MaintenanceDate = c.Int(nullable: false),
                        MaintenanceType = c.String(),
                        Description = c.String(),
                        Cost = c.Single(nullable: false),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MaterialAssignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Project = c.String(nullable: false, maxLength: 100),
                        Material = c.String(nullable: false, maxLength: 100),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Materials",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaterialName = c.String(nullable: false, maxLength: 100),
                        QuantityInStock = c.String(nullable: false, maxLength: 100),
                        PricePerUnit = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Order = c.String(nullable: false, maxLength: 50),
                        Material = c.String(nullable: false, maxLength: 100),
                        Quantity = c.Single(nullable: false),
                        PricePerUnit = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderDate = c.DateTime(nullable: false),
                        DeliveryDate = c.DateTime(nullable: false),
                        TotalCost = c.Single(nullable: false),
                        Details = c.String(maxLength: 500),
                        Provider = c.String(nullable: false, maxLength: 100),
                        Department = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProjectDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ServiceType = c.String(),
                        Cost = c.Single(nullable: false),
                        Project = c.String(),
                        Service = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Client = c.String(nullable: false, maxLength: 200),
                        ProjectName = c.String(nullable: false, maxLength: 150),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        AssignationDate = c.DateTime(nullable: false),
                        Budget = c.Single(nullable: false),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProviderName = c.String(nullable: false, maxLength: 100),
                        PhoneNumber = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 100),
                        Street = c.String(nullable: false, maxLength: 100),
                        ExteriorNumber = c.String(maxLength: 10),
                        City = c.String(nullable: false, maxLength: 100),
                        State = c.String(nullable: false, maxLength: 100),
                        Township = c.String(nullable: false, maxLength: 50),
                        ZipCode = c.String(nullable: false, maxLength: 10),
                        Material = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Cost = c.Single(nullable: false),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ToolAssignments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        Tool = c.String(),
                        Project = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tools",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        QuantityAvailable = c.Int(nullable: false),
                        ToolAssignment = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tools");
            DropTable("dbo.ToolAssignments");
            DropTable("dbo.Services");
            DropTable("dbo.Providers");
            DropTable("dbo.Projects");
            DropTable("dbo.ProjectDetails");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Materials");
            DropTable("dbo.MaterialAssignments");
            DropTable("dbo.Maintenances");
            DropTable("dbo.MaintenanceDetails");
            DropTable("dbo.MachineryAssignments");
            DropTable("dbo.Machineries");
            DropTable("dbo.Departments");
            DropTable("dbo.Clients");
        }
    }
}
