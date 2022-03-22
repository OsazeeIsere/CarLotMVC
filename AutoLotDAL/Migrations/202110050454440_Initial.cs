﻿namespace AutoLotDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditRisks",
                c => new
                    {
                        CustID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CustID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustID = c.Int(nullable: false, identity: true),
                        FirstNAme = c.String(maxLength: 50),
                        LastNAme = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CustID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        CustID = c.Int(nullable: false),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Inventory", t => t.CarId)
                .ForeignKey("dbo.Customers", t => t.CustID, cascadeDelete: true)
                .Index(t => t.CustID)
                .Index(t => t.CarId);
            
            CreateTable(
                "dbo.Inventory",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        Make = c.String(maxLength: 50),
                        Color = c.String(maxLength: 50),
                        PetName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.CarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CustID", "dbo.Customers");
            DropForeignKey("dbo.Orders", "CarId", "dbo.Inventory");
            DropIndex("dbo.Orders", new[] { "CarId" });
            DropIndex("dbo.Orders", new[] { "CustID" });
            DropTable("dbo.Inventory");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
            DropTable("dbo.CreditRisks");
        }
    }
}
