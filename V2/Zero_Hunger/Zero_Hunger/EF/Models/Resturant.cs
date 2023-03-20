using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Zero_Hunger.EF.Models;

namespace ZeroHunger.Ef.Models
{
    public class Resturant
    {
        [Key]
        public int ResId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string FoodType { get; set; }
        public string MaxPreTime { get; set; }
        public virtual ICollection<CollectRequests> CollectRequests { get; set; }
        public virtual ICollection<Food> Foods { get; set; }
        public Resturant()
        {
            Foods = new List<Food>();
            CollectRequests = new List<CollectRequests>();
        }
    }
}