using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_Rental_Project.Models.Cars
{
    public class UpdateCarModel
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal PricePerDay { get; set; }

    }
}