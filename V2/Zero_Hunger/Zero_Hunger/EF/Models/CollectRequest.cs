using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ZeroHunger.Ef.Models
{
    public class CollectRequests
    {
        [Key]
        public int CrId { get; set; }
        [ForeignKey("Employees")]
        public int? EmployeeId { get; set; }
        [ForeignKey("Resturant")]
        public int ResId { get; set; }
        public string FoodName { get; set; }
        public DateTime MaxPresDate { get; set; }
        public string CollectionDate { get; set; }
        public virtual Employees Employees { get; set; }
        public virtual Resturant Resturant { get; set; }

    }
}