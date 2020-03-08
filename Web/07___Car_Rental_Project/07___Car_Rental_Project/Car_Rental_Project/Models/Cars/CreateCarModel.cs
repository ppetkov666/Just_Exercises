
namespace Car_Rental_Project.Models.Cars
{
    using Car_Rental_Project.Data;
    using Car_Rental_Project.Infrastructure;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    public class CreateCarModel
    {
        [Required(ErrorMessage = "Please enter Car Make")]
        [MaxLength(50)]
        public string Make { get; set; }

        [Required(ErrorMessage = "Please enter Car Model")]
        public string Model { get; set; }

        [Range(1990, 2019, ErrorMessage = "Enter a year between present year and 1990")]
        public int Year { get; set; }

        // in horse powers
        public int? Power { get; set; }

        public double Engine { get; set; }

        [Display(Name = "Engine Type")]
        // this attribute is because i dont want this particullar property to be auto generated from the View
        [ScaffoldColumn(false)]
        public EngineType EngineType { get; set; }

        public string Color { get; set; }

        // in BGN (Leva)
        [Display(Name = "Price in BGN per day")]
        public decimal PricePerDay { get; set; }

        [Url]
        [CustomRequired]
        [Display(Name = "Image")]
        [Image(ErrorMessage ="Image format must be one of the following: /.jpg /.jpeg /.png/.gif")]
        public string ImageUrl { get; set; }
    }
}