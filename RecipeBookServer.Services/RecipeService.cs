using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeBookServer.Model;
using RecipeBookServer.Repository;

namespace RecipeBookServer.Services
{
  public  class RecipeService
    {
        RecipeRepository repo = new RecipeRepository();
        public bool Add(Recipe recipe)
        {
           
            return repo.Add(recipe);
        }

        public List<Recipe> GetRecipes()
        {
            return repo.GetRecipes();
        }
    }
}
