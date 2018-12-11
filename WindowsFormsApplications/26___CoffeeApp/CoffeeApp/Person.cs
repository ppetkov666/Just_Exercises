using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeApp
{
    class Person : f_main_form
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string FullName
        {
            get { return $"{this.Firstname} {this.Lastname}"; }

        }
    }
}
