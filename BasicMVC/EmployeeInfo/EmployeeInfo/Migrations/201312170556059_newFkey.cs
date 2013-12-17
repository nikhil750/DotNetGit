namespace EmployeeInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newFkey : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.EmployeeGit", "BranchName");
            DropTable("dbo.EmployeeBranch");
            CreateTable(
                "dbo.EmployeeBranch",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        Branch = c.String(),
                        EmployeeGit_EmployeeID = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.EmployeeGit", t => t.EmployeeGit_EmployeeID)
                .Index(t => t.EmployeeGit_EmployeeID);
            
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeeGit", "BranchName", c => c.String());
            DropIndex("dbo.EmployeeBranch", new[] { "EmployeeGit_EmployeeID" });
            DropForeignKey("dbo.EmployeeBranch", "EmployeeGit_EmployeeID", "dbo.EmployeeGit");
            DropTable("dbo.EmployeeBranch");
        }
    }
}
