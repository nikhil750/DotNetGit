namespace EmployeeInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBranchNew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EmployeeGit", "BranchName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EmployeeGit", "BranchName");
        }
    }
}
