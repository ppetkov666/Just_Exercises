using Car_Rental_Project.Models.Cars;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Car_Rental_Project.Infrastructure
{
    public class CustomRequiredAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            CreateCarModel model = (CreateCarModel)validationContext.ObjectInstance;
            if (model.ImageUrl == null)
            {
                return new ValidationResult("Image field is required!");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}