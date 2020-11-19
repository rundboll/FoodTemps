namespace ApiMeatTemp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Namechanged : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.FoodTypes", newName: "Kj_FoodType");
            RenameTable(name: "dbo.Recipes", newName: "Kj_Recipe");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Kj_Recipe", newName: "Recipes");
            RenameTable(name: "dbo.Kj_FoodType", newName: "FoodTypes");
        }
    }
}
