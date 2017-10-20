namespace RecipeBookServer.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 100),
                        Amout = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 100),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(nullable: false, maxLength: 100),
                        Recipe_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id)
                .Index(t => t.Recipe_Id);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 100),
                        Description = c.String(nullable: false, maxLength: 100),
                        ImagePath = c.String(nullable: false, maxLength: 500),
                        Created = c.DateTime(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 100),
                        Modified = c.DateTime(nullable: false),
                        ModifiedBy = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ingredients", "Recipe_Id", "dbo.Recipes");
            DropIndex("dbo.Ingredients", new[] { "Recipe_Id" });
            DropTable("dbo.Recipes");
            DropTable("dbo.Ingredients");
        }
    }
}
