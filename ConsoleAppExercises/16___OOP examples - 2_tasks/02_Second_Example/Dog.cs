using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Second_Example
{
    class Dog:Animal
    {
        public Dog(string name):base(name)
        {
            var animal = new Animal(name);
            // this is possible because the field in Animal class is public 
            // if i change it to private this will be no more accesible !
            var tiger = animal.name;
        }
        public void SetName()
        {
            this.Name = "Dangerous";
            Console.WriteLine(this.Name);
        }
    }
}
