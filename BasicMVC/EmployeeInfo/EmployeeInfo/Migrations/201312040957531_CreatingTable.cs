namespace EmployeeInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeModels",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(nullable: false),
                        Designation = c.String(nullable: false),
                        DateofJoining = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            DropTable("dbo.EmployeeInfoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmployeeInfoes",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(nullable: false),
                        Designation = c.String(nullable: false),
                        DateofJoining = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            DropTable("dbo.EmployeeModels");
        }
    }
}
