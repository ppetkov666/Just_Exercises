
namespace Car_Rental_Project.Models.Cars
{
    using Car_Rental_Project.Data;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class CarEditDetails
    {
        [ScaffoldColumn(false)]
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

        [ScaffoldColumn(false)]
        public EngineType EngineType { get; set; }

        public string Color { get; set; }

        // in BGN (Leva)
        public decimal PricePerDay { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [ScaffoldColumn(false)]
        [Required]
        public string OwnerId { get; set; }

        public virtual User Owner { get; set; }
    }
}