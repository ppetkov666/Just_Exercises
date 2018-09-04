using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Second_Example
{
    abstract class Car
    {
        public string Name { get; set; }

        public string Model { get; }

       public virtual string StartElectricEngine()
       {
           return "I am electric Car: ";
       }

        public virtual string StartEngine()
        {
            return "Regular Car start: ";
        }
    }
}
