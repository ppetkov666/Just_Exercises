
namespace AdoConnectionApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    

    public class Person : Form
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }


        private string country;
        public string Country
        {
            get
            {
                return this.country;
            }
            set
            {
                if (string.IsNullOrEmpty(country))
                {
                    country = "NoWhere";
                }
                country = value;
            }
        }

        public string FullInfo
        {
            get { return $"{this.Firstname} {this.Lastname} - {this.Age} years old from {this.Country}"; }
            
        }

    }
}
