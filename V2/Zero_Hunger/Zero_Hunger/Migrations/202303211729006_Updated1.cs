namespace Zero_Hunger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updated1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CollectRequests", "CollectionDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CollectRequests", "CollectionDate", c => c.DateTime(nullable: false));
        }
    }
}
