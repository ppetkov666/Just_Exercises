namespace Coffee_System.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }

        public List<UserDrink> Drinks { get; set; } = new List<UserDrink>();
    }
}
