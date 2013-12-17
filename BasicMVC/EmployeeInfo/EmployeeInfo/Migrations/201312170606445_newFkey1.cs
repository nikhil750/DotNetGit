namespace EmployeeInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newFkey1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmployeeBranch", "EmployeeGit_EmployeeID", "dbo.EmployeeGit");
            DropIndex("dbo.EmployeeBranch", new[] { "EmployeeGit_EmployeeID" });
            DropTable("dbo.EmployeeBranch");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EmployeeBranch",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        Branch = c.String(),
                        EmployeeGit_EmployeeID = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeID);
            
            CreateIndex("dbo.EmployeeBranch", "EmployeeGit_EmployeeID");
            AddForeignKey("dbo.EmployeeBranch", "EmployeeGit_EmployeeID", "dbo.EmployeeGit", "EmployeeID");
        }
    }
}
