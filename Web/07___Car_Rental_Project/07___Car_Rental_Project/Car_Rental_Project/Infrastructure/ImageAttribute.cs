using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Car_Rental_Project.Infrastructure
{
    public class ImageAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string imageUrl = value as string;
            if (imageUrl == null)
            {
                return true;
            }

            return imageUrl.EndsWith("jpeg") ||
                   imageUrl.EndsWith("jpg")  ||
                   imageUrl.EndsWith("png")  ||
                   imageUrl.EndsWith("gif");

        }
    }
}