using ApiMeatTemp.JsonClasses;
using ApiMeatTemp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiMeatTemp.Handlers
{
    public class RecipeHandler : BaseHandler 
    {
        public List<JsonRecipe> GetAllFoodFromOneType(int FoodTypeId)
        {
            List<JsonRecipe> listOfJsonRecipes = new List<JsonRecipe>();
            var listOfRecipes = FoodDb.Recipes.Where(n => n.FoodTypeId == FoodTypeId).ToList();
            foreach (var item in listOfRecipes)
            {
                JsonRecipe oneRecipe = GetOneJsonRecipe(item);
                listOfJsonRecipes.Add(oneRecipe);
            }
            return listOfJsonRecipes;
        }
        public JsonRecipe GetOneJsonRecipe(Recipe recipe)
        {

            JsonRecipe jsonrecipe = new JsonRecipe
            {
                Id = recipe.Id,
                Name = recipe.Name,
                FoodTemperature = recipe.FoodTemperature,
                OvenTemperature = recipe.OvenTemperature,
                Instruction = recipe.Instruction,
                FoodType = GetOneFoodType(recipe.FoodTypeId)
            };
            return jsonrecipe;
        }
        public List<JsonRecipe> GetAllFoodFromOneTypeUsingName(string foodName)
        {
            List<JsonRecipe> listOfJsonRecipes = new List<JsonRecipe>();
            var listOfRecipes = FoodDb.Recipes.Where(n => n.Foodtypes.FoodName.ToUpper() == foodName.ToUpper()).ToList();
            foreach (var item in listOfRecipes)
            {
                JsonRecipe oneRecipe = GetOneJsonRecipe(item);
                listOfJsonRecipes.Add(oneRecipe);
            }
            return listOfJsonRecipes;
        }
        public JsonRecipe GetOneJsonRecipeUsingName(Recipe recipe)
        {

            JsonRecipe jsonrecipe = new JsonRecipe
            {
                Id = recipe.Id,
                Name = recipe.Name,
                FoodTemperature = recipe.FoodTemperature,
                OvenTemperature = recipe.OvenTemperature,
                Instruction = recipe.Instruction,
                FoodType = GetOneFoodType(recipe.FoodTypeId)
            };
            return jsonrecipe;
        }

        private JsonFoodType GetOneFoodType(int foodTypeId)
        {
            var oneFoodType = FoodDb.FoodTypes.FirstOrDefault(n => n.Id == foodTypeId);
            JsonFoodType jsonFood = new JsonFoodType
            {
                Id = oneFoodType.Id,
                FoodName = oneFoodType.FoodName
            };
            return jsonFood;
        }
    }
}