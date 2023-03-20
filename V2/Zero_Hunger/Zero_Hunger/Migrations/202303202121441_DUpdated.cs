namespace Zero_Hunger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Distributions", "FoodName", c => c.String(nullable: false));
            AddColumn("dbo.Distributions", "ResturantName", c => c.String(nullable: false));
            AddColumn("dbo.Distributions", "EmployeeId", c => c.String(nullable: false));
            AddColumn("dbo.Distributions", "CollectionDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Distributions", "FoodType");
            DropColumn("dbo.Distributions", "ResId");
            DropColumn("dbo.Distributions", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Distributions", "Date", c => c.String(nullable: false));
            AddColumn("dbo.Distributions", "ResId", c => c.String(nullable: false));
            AddColumn("dbo.Distributions", "FoodType", c => c.String(nullable: false));
            DropColumn("dbo.Distributions", "CollectionDate");
            DropColumn("dbo.Distributions", "EmployeeId");
            DropColumn("dbo.Distributions", "ResturantName");
            DropColumn("dbo.Distributions", "FoodName");
        }
    }
}
