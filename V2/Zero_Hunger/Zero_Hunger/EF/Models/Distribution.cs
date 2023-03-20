using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZeroHunger.Ef.Models
{
    public class Distribution
    {
        [Key]
        public int DId { get; set; }
        [Required]
        public string FoodName { get; set; }
        [Required]
        public string ResturantName { get; set; }
        [Required]
        public string EmployeeId { get; set; }
        public DateTime CollectionDate { get; set; }
    }
}