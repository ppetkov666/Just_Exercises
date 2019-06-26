using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    class Drink
    {
        public string DrinkName { get; set; }
        public decimal Total { get; set; }
        public decimal DrinkQuantity { get; set; }

        public string DetailedInfo
        {
            get { return $"Drink Type: {this.DrinkName}, Quantity: {DrinkQuantity:f0}, Total Amount: {this.Total:f2} leva"; }

        }
       
    }
}
