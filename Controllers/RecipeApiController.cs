using ApiMeatTemp.Handlers;
using ApiMeatTemp.JsonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiMeatTemp.Controllers
{
    public class RecipeApiController : ApiController
    {
        private RecipeHandler _RecipeHandler = new RecipeHandler();
        // GET: api/RecipeApi
        private string key = "Blue";

        // GET: api/RecipeApi/5
        [Route("api/foodList")] 
        public List<JsonRecipe> Get(string foodName, string appKey)
        {
            if (key==appKey)
            {
                return _RecipeHandler.GetAllFoodFromOneTypeUsingName(foodName);
            }
            else
            {
                return null;
            }

           
        }
    }
}
