    using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
    using System.Web.Http.Results;
    using RecipeBookServer.Model;
    using RecipeBookServer.Services;

namespace RecipeBookServer.ServerAPI.Controllers
{
    public class RecipeController : ApiController
    {
        RecipeService service = new RecipeService();
        public IHttpActionResult Post(Recipe recipe)
        {
            bool add = service.Add(recipe);
            return this.Ok(add);
        }

        public IHttpActionResult PostRecipes(List<Recipe> recipe)
        {
            bool add = service.Add(recipe);
            return this.Ok(add);
        }

        public List<Recipe> GetRecipes()
        {
            return service.GetRecipes();
        }
    }
}
