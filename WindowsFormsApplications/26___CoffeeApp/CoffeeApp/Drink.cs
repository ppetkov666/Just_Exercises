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
        public string DetailedInfo
        {
            get { return $"{this.DrinkName} - {this.Total:f2} leva"; }

        }
       
    }
}
