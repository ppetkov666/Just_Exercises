using System;
using System.Collections.Generic;
using System.Text;

namespace _01_First_Example.Animals
{
    abstract class Animal
    {
      //this is WRONG because it could be overrided later and 
      //Animal could have Invalid State
      //public Animal()
      //{
      //    this.SayHello();
      //}

        public string Name { get; set; }
        public string Color { get; set; }

        public abstract string SayHello();
        public virtual string PrintMyName()
        {
            return "I am ";
        }

    }
}
