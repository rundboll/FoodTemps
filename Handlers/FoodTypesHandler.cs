using ApiMeatTemp.JsonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiMeatTemp.Handlers
{
    public class FoodTypesHandler : BaseHandler
    {
        public List<JsonFoodType> GetAllFoodTypes()
        {
            var listOfFoodTypes = FoodDb.FoodTypes.ToList();
            List<JsonFoodType> listOfJsonFoodTypes = new List<JsonFoodType>();
            foreach (var item in listOfFoodTypes)
            {
                JsonFoodType oneJsonFoodType = new JsonFoodType
                {
                    Id = item.Id,
                    FoodName = item.FoodName
                };
                listOfJsonFoodTypes.Add(oneJsonFoodType);
            }
            return listOfJsonFoodTypes;
        }
    }
}