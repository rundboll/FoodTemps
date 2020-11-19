namespace ApiMeatTemp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class setup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FoodName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        FoodTemperature = c.Int(),
                        OvenTemperature = c.Int(),
                        Instruction = c.String(),
                        FoodTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FoodTypes", t => t.FoodTypeId, cascadeDelete: true)
                .Index(t => t.FoodTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recipes", "FoodTypeId", "dbo.FoodTypes");
            DropIndex("dbo.Recipes", new[] { "FoodTypeId" });
            DropTable("dbo.Recipes");
            DropTable("dbo.FoodTypes");
        }
    }
}
