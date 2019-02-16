namespace Coffee_System.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class UserDrink
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int DrinkId { get; set; }
        public Drink Drink { get; set; }

    }
}
