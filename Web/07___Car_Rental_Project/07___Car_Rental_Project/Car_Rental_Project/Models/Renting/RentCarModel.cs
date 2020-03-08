using Car_Rental_Project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Car_Rental_Project.Models.Renting
{
    public class RentCarModel
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarImageUrl { get; set; }
        public int Days { get; set; }
        public decimal PricePerDay{ get; set; }
        [Display(Name = "Do you have a valid driver license ?")]
        public decimal TotalPrice { get; set; }

    }
}