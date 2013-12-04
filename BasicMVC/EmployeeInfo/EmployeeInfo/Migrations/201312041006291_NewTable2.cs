namespace EmployeeInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTable2 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.EmployeeGit");
            CreateTable(
                "dbo.EmployeeGit",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(nullable: false),
                        Designation = c.String(nullable: false),
                        DateofJoining = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmployeeGit",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(nullable: false),
                        Designation = c.String(nullable: false),
                        DateofJoining = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            DropTable("dbo.EmployeeGit");
        }
    }
}
