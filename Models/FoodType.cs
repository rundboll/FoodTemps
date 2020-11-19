using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiMeatTemp.Models
{
    [Table("Kj_FoodType")]
    public class FoodType
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Food name")]
        public string FoodName { get; set; }
        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}