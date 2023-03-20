namespace Zero_Hunger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CRTableUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CollectRequests", "FoodName", c => c.String());
            AddColumn("dbo.CollectRequests", "MaxPresDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.CollectRequests", "CollectionDate");
            DropColumn("dbo.CollectRequests", "FoodType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CollectRequests", "FoodType", c => c.String());
            AddColumn("dbo.CollectRequests", "CollectionDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.CollectRequests", "MaxPresDate");
            DropColumn("dbo.CollectRequests", "FoodName");
        }
    }
}
