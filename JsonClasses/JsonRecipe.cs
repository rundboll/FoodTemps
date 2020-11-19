using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiMeatTemp.JsonClasses
{
    public class JsonRecipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? FoodTemperature { get; set; }
        public int? OvenTemperature { get; set; }
        public string Instruction { get; set; }
        public JsonFoodType FoodType { get; set; }
    }
}