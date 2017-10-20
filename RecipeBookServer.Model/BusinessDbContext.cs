using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecipeBookServer.Model.Recipes;

namespace RecipeBookServer.Model
{
    public class BusinessDbContext: DbContext
    {
        public BusinessDbContext():base("DefaultBusinessConnection")
        {
            
        }
        public DbSet<Recipe> Recipes { set; get; }
        public DbSet<Ingredient> Ingredients { set; get; }
    }
}
