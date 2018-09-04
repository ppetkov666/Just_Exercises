using System;
using System.Collections.Generic;
using System.Text;

namespace _01_First_Example.Animals
{
    class Dog:Animal
    {
        
        public override string SayHello()
        {
            return "Bauuu";
        }
        public override string PrintMyName()
        {
            return $"{base.PrintMyName()} Dog";

        }
    }
}
