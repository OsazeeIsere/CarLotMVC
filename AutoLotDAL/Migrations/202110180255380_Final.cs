﻿namespace AutoLotDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "CustID", "dbo.Customers");
            DropForeignKey("dbo.Orders", "CarId", "dbo.Inventory");
            RenameColumn(table: "dbo.Orders", name: "CustID", newName: "CustomerId");
            RenameIndex(table: "dbo.Orders", name: "IX_CustID", newName: "IX_CustomerId");
            DropPrimaryKey("dbo.CreditRisks");
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.Orders");
            DropPrimaryKey("dbo.Inventory");
            DropColumn("dbo.Inventory", "CarId");
            DropColumn("dbo.Orders", "OrderId");
            DropColumn("dbo.Customers", "CustID");
            DropColumn("dbo.CreditRisks", "CustID");

            AddColumn("dbo.CreditRisks", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.CreditRisks", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Customers", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Customers", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Orders", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Orders", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Inventory", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Inventory", "Timestamp", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddPrimaryKey("dbo.CreditRisks", "Id");
            AddPrimaryKey("dbo.Customers", "Id");
            AddPrimaryKey("dbo.Orders", "Id");
            AddPrimaryKey("dbo.Inventory", "Id");
            CreateIndex("dbo.CreditRisks", new[] { "LastName", "FirstName" }, unique: true, name: "IDX_CreditRisk_Name");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "CarId", "dbo.Inventory", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CarId", "dbo.Inventory");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropPrimaryKey("dbo.Inventory");
            DropPrimaryKey("dbo.Orders");
            DropPrimaryKey("dbo.Customers");
            DropPrimaryKey("dbo.CreditRisks");
            DropColumn("dbo.Inventory", "Timestamp");
            DropColumn("dbo.Inventory", "Id");
            DropColumn("dbo.Orders", "Timestamp");
            DropColumn("dbo.Orders", "Id");
            DropColumn("dbo.Customers", "Timestamp");
            DropColumn("dbo.Customers", "Id");
            DropColumn("dbo.CreditRisks", "Timestamp");
            DropColumn("dbo.CreditRisks", "Id");

            AddColumn("dbo.Inventory", "CarId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Orders", "OrderId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Customers", "CustID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.CreditRisks", "CustID", c => c.Int(nullable: false, identity: true));
            //DropForeignKey("dbo.Orders", "CarId", "dbo.Inventory");
            //DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.CreditRisks", "IDX_CreditRisk_Name");
            //DropPrimaryKey("dbo.Inventory");
            //DropPrimaryKey("dbo.Orders");
            //DropPrimaryKey("dbo.Customers");
            //DropPrimaryKey("dbo.CreditRisks");
            //DropColumn("dbo.Inventory", "Timestamp");
            //DropColumn("dbo.Inventory", "Id");
            //DropColumn("dbo.Orders", "Timestamp");
            //DropColumn("dbo.Orders", "Id");
            //DropColumn("dbo.Customers", "Timestamp");
            //DropColumn("dbo.Customers", "Id");
            //DropColumn("dbo.CreditRisks", "Timestamp");
            //DropColumn("dbo.CreditRisks", "Id");
            AddPrimaryKey("dbo.Inventory", "CarId");
            AddPrimaryKey("dbo.Orders", "OrderId");
            AddPrimaryKey("dbo.Customers", "CustID");
            AddPrimaryKey("dbo.CreditRisks", "CustID");
            RenameIndex(table: "dbo.Orders", name: "IX_CustomerId", newName: "IX_CustID");
            RenameColumn(table: "dbo.Orders", name: "CustomerId", newName: "CustID");
            AddForeignKey("dbo.Orders", "CarId", "dbo.Inventory", "CarId");
            AddForeignKey("dbo.Orders", "CustID", "dbo.Customers", "CustID", cascadeDelete: true);
        }
    }
}
