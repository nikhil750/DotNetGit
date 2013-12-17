namespace EmployeeInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newFkey4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmployeeGit", "EmployeeBranch_EmployeeID", "dbo.EmployeeBranch");
            DropIndex("dbo.EmployeeGit", new[] { "EmployeeBranch_EmployeeID" });
            DropColumn("dbo.EmployeeGit", "EmployeeBranch_EmployeeID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeeGit", "EmployeeBranch_EmployeeID", c => c.Int());
            CreateIndex("dbo.EmployeeGit", "EmployeeBranch_EmployeeID");
            AddForeignKey("dbo.EmployeeGit", "EmployeeBranch_EmployeeID", "dbo.EmployeeBranch", "EmployeeID");
        }
    }
}
