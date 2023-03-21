namespace Zero_Hunger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedDistribution : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Distributions", "EmployeeName", c => c.String(nullable: false));
            DropColumn("dbo.Distributions", "EmployeeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Distributions", "EmployeeId", c => c.String(nullable: false));
            DropColumn("dbo.Distributions", "EmployeeName");
        }
    }
}
