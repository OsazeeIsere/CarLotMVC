﻿namespace AutoLotDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Inventory", "Make", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Inventory", "Color", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Inventory", "PetName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Inventory", "PetName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Inventory", "Color", c => c.String(maxLength: 50));
            AlterColumn("dbo.Inventory", "Make", c => c.String(maxLength: 50));
        }
    }
}
