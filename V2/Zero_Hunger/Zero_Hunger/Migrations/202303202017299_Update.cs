namespace Zero_Hunger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserName);
            
            CreateTable(
                "dbo.CollectRequests",
                c => new
                    {
                        CrId = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(),
                        ResId = c.Int(nullable: false),
                        CollectionDate = c.DateTime(nullable: false),
                        FoodType = c.String(),
                    })
                .PrimaryKey(t => t.CrId)
                .ForeignKey("dbo.Employees", t => t.EmployeeId)
                .ForeignKey("dbo.Resturants", t => t.ResId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.ResId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(nullable: false),
                        Phone = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Resturants",
                c => new
                    {
                        ResId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Phone = c.String(),
                        Address = c.String(),
                        FoodType = c.String(),
                        MaxPreTime = c.String(),
                    })
                .PrimaryKey(t => t.ResId);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        FoodId = c.Int(nullable: false, identity: true),
                        FoodName = c.String(nullable: false),
                        ResId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FoodId)
                .ForeignKey("dbo.Resturants", t => t.ResId, cascadeDelete: true)
                .Index(t => t.ResId);
            
            CreateTable(
                "dbo.Distributions",
                c => new
                    {
                        DId = c.Int(nullable: false, identity: true),
                        FoodType = c.String(nullable: false),
                        ResId = c.String(nullable: false),
                        Date = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.DId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CollectRequests", "ResId", "dbo.Resturants");
            DropForeignKey("dbo.Foods", "ResId", "dbo.Resturants");
            DropForeignKey("dbo.CollectRequests", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Foods", new[] { "ResId" });
            DropIndex("dbo.CollectRequests", new[] { "ResId" });
            DropIndex("dbo.CollectRequests", new[] { "EmployeeId" });
            DropTable("dbo.Distributions");
            DropTable("dbo.Foods");
            DropTable("dbo.Resturants");
            DropTable("dbo.Employees");
            DropTable("dbo.CollectRequests");
            DropTable("dbo.Admins");
        }
    }
}
