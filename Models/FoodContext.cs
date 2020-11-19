using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiMeatTemp.Models
{
    public class FoodContext : DbContext
    {
        public FoodContext()
        {

        }
        public DbSet<FoodType> FoodTypes { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
    }

}
