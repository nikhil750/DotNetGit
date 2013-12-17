namespace EmployeeInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingJunctionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JunctionEmployeeBranch",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false),
                        BranchID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmployeeID, t.BranchID })
                .ForeignKey("dbo.EmployeeGit", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("dbo.EmployeeBranch", t => t.BranchID, cascadeDelete: true)
                .Index(t => t.EmployeeID)
                .Index(t => t.BranchID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.JunctionEmployeeBranch", new[] { "BranchID" });
            DropIndex("dbo.JunctionEmployeeBranch", new[] { "EmployeeID" });
            DropForeignKey("dbo.JunctionEmployeeBranch", "BranchID", "dbo.EmployeeBranch");
            DropForeignKey("dbo.JunctionEmployeeBranch", "EmployeeID", "dbo.EmployeeGit");
            DropTable("dbo.JunctionEmployeeBranch");
        }
    }
}
