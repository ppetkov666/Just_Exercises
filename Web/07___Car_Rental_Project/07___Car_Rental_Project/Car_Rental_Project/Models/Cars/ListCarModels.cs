using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_Rental_Project.Models.Cars
{
    public class ListCarModels
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal DailyPrice { get; set; }
        public string ImageUrl { get; set; }
        public bool IsRented { get; set; }

    }
}