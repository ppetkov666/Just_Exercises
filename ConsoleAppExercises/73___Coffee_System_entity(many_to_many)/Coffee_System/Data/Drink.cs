namespace Coffee_System.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;
    public class Drink
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<UserDrink> Users { get; set; }  = new List<UserDrink>();

    }
}
