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
            return true;
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
