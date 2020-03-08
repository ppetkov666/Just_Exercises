using Car_Rental_Project.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Car_Rental_Project.Dto_s
{
    public class CarDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Range(1990, 2019)]
        public int Year { get; set; }

        // in horse powers
        public int? Power { get; set; }

        public double Engine { get; set; }

        public EngineType EngineType { get; set; }

        public string Color { get; set; }

        // in BGN (Leva)
        public decimal PricePerDay { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public bool IsRented { get; set; }

        [Required]
        [ForeignKey("Owner")]
        public string OwnerId { get; set; }

        public virtual ICollection<Renting> Rentings { get; set; }
    }
}