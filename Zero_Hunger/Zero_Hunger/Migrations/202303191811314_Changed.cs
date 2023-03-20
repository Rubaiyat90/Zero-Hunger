namespace Zero_Hunger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DistributionDetails", "ResId", c => c.String(nullable: false));
            DropColumn("dbo.DistributionDetails", "ResTurantName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DistributionDetails", "ResTurantName", c => c.String(nullable: false));
            DropColumn("dbo.DistributionDetails", "ResId");
        }
    }
}
