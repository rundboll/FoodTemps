using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ApiMeatTemp.Handlers;
using ApiMeatTemp.JsonClasses;
using ApiMeatTemp.Models;

namespace ApiMeatTemp.Controllers
{
    public class FoodTypesApiController : ApiController
    {
        private FoodTypesHandler foodTypesHandler = new FoodTypesHandler();
        private FoodContext db = new FoodContext();
        private string key = "GreenDiamondSlope";

        // GET: api/FoodTypesApi
        [Route("api/foodType")]
        public List<JsonFoodType> GetFoodTypes(string appKey)
        {
            if (key == appKey)
            {
                return foodTypesHandler.GetAllFoodTypes();
            }
            return null;
        }           


    }
}