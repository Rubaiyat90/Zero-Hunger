using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using ZeroHunger.Ef.Models;

namespace Zero_Hunger.EF.Models
{
    public class Food
    {
        [Key]
        public int FoodId { get; set; }
        [Required]
        public string FoodName { get; set; }
        [ForeignKey("Resturant")]
        public int ResId { get; set; }
        public virtual Resturant Resturant { get; set; }
    }
}