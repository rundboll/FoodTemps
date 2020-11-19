using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiMeatTemp.Models
{
    [Table("Kj_Recipe")]
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name="Food temperature")]
        public int? FoodTemperature { get; set; }
        [Display(Name="Oven temperature")]
        public int? OvenTemperature { get; set; }
        public string Instruction { get; set; }
        [Display(Name="Food type")]

        public int FoodTypeId { get; set; }
        [ForeignKey("FoodTypeId")]
        [Display(Name = "Food type")]
        public virtual FoodType Foodtypes { get; set; }

    }
}