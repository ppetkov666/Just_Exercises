using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    public class VegeterianPizza : Pizza
    {
        public VegeterianPizza(string name, string flavor):base(name, flavor)
        {

        }
        public override void BakeIt()
        {
            Console.WriteLine("35 min on 220 CELSIUS degree");
        }
    }
}
