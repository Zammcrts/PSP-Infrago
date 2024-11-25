namespace PSP_Infrago.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class partialCorrectionClients : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clients", "Phone", c => c.String(maxLength: 15));
            AlterColumn("dbo.Clients", "Email", c => c.String(maxLength: 200));
            AlterColumn("dbo.Clients", "Street", c => c.String(maxLength: 100));
            AlterColumn("dbo.Clients", "State", c => c.String(maxLength: 50));
            AlterColumn("dbo.Clients", "Township", c => c.String(maxLength: 50));
            AlterColumn("dbo.Clients", "City", c => c.String(maxLength: 50));
            AlterColumn("dbo.Clients", "ZipCode", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clients", "ZipCode", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Clients", "City", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Clients", "Township", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Clients", "State", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Clients", "Street", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Clients", "Email", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Clients", "Phone", c => c.String(nullable: false, maxLength: 15));
        }
    }
}
