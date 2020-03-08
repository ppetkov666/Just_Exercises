using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Car_Rental_Project.Models
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
