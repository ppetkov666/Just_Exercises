namespace Car_Rental_Project.Models.Cars
{
    using Car_Rental_Project.Data;
    using Car_Rental_Project.Infrastructure;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CarModelDetails
    { 
        public int Id { get; set; }

        public string Make { get; set; }
       
        public string Model { get; set; }

        public int? Year { get; set; }

        public int? Power { get; set; }

        public double Engine { get; set; }
        
        public EngineType EngineType { get; set; }

        public string Color { get; set; }        
        
        public decimal PricePerDay { get; set; }

        public string ImageUrl { get; set; }

        public string ContactInfo { get; set; }

        public bool IsRented { get; set; }

        public int TotalRents { get; set; }

    }
}