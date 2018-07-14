using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Dog:Animal
    {
        public Dog(string name, int age ):base(name,age)
        {

        }

        public override string Run => "i am dog and i like to run";

        public override string SayHello()
        {
            return "i am dog";
        }
    }
}
