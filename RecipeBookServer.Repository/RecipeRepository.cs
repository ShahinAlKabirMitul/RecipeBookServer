using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeBookServer.Model;

namespace RecipeBookServer.Repository
{
   public class RecipeRepository
    {
        public bool Add(Recipe recipe)
        {
            using (var db=new BusinessDbContext())
            {
                recipe.Id=Guid.NewGuid().ToString();
                recipe.Created = System.DateTime.Now;
                recipe.Modified = recipe.Created;
                recipe.CreatedBy = "Mitul";
                recipe.ModifiedBy = "Mitul";
                foreach (Ingredient ingredient in recipe.Ingredients)
                {
                    ingredient.Id = Guid.NewGuid().ToString();
                    ingredient.RecipeId = recipe.Id;
                    ingredient.Created = System.DateTime.Now;
                    ingredient.Modified = recipe.Created;
                    ingredient.CreatedBy = "Mitul";
                    ingredient.ModifiedBy = "Mitul";
                }
                db.Recipes.Add(recipe);
                
                db.SaveChanges();
                return true;
            }
        }

        public bool Add(List<Recipe> recipes)
        {
            using (var db=new BusinessDbContext())
            {
                bool result = false;
               
                foreach (Recipe recipe in recipes)
                {
                    recipe.Id = Guid.NewGuid().ToString();
                    recipe.Created = System.DateTime.Now;
                    recipe.Modified = recipe.Created;
                    recipe.CreatedBy = "Mitul";
                    recipe.ModifiedBy = "Mitul";
                    foreach (Ingredient ingredient in recipe.Ingredients)
                    {
                        ingredient.Id = Guid.NewGuid().ToString();
                        ingredient.RecipeId = recipe.Id;
                        ingredient.Created = System.DateTime.Now;
                        ingredient.Modified = recipe.Created;
                        ingredient.CreatedBy = "Mitul";
                        ingredient.ModifiedBy = "Mitul";
                    }
                    db.Recipes.Add(recipe);

                    db.SaveChanges();
                    result = true;
                }
                return result;
            }
        }

        public List<Recipe> GetRecipes()
         {
            using (var db=new BusinessDbContext())
            {
                return db.Recipes.ToList();
            }
        }
    }
}
