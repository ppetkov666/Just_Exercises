using System;
using System.Collections.Generic;
using System.Text;

namespace _01_First_Example.Animals
{
    class Bunny:Animal
    {
        
        public override string SayHello()
        {
            return string.Empty;
        }
        public override string PrintMyName()
        {
            return $"{base.PrintMyName()} Bunny";

        }

    }
}
