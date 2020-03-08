using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_Rental_Project.Models.Renting
{
    public class UserRentingModel
    {
        public int Days { get; set; }

        public DateTime RentedOn { get; set; }

        public decimal TotalPrice { get; set; }

        public int CarId { get; set; }

        public string CarName { get; set; }

        public string CarImageUrl { get; set; }

    }
}