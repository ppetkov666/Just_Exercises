using System;
using System.Collections.Generic;
using System.Text;

namespace _01_First_Example.Animals
{
    class Cat:Animal
    {

       //public Cat():base()
       //{
       //
       //}
        public override string SayHello()
        {
            return "Myauuu";
        }
        public override string PrintMyName()
        {
            return $"{base.PrintMyName()} Cat";
        }
    }
}
