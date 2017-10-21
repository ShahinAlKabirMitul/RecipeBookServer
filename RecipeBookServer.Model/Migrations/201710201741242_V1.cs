namespace RecipeBookServer.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Ingredients", name: "Recipe_Id", newName: "RecipeId");
            RenameIndex(table: "dbo.Ingredients", name: "IX_Recipe_Id", newName: "IX_RecipeId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Ingredients", name: "IX_RecipeId", newName: "IX_Recipe_Id");
            RenameColumn(table: "dbo.Ingredients", name: "RecipeId", newName: "Recipe_Id");
        }
    }
}
