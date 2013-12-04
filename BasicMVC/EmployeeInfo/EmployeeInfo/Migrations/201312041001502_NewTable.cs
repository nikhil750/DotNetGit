namespace EmployeeInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTable : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.EmployeeModels", newName: "EmployeeGit");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.EmployeeGit", newName: "EmployeeModels");
        }
    }
}
