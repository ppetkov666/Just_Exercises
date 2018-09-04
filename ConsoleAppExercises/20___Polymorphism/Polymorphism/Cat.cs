using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Cat:Animal
    {
        public Cat(string name, int age):base(name,age)
        {

        }

        public override string Run { get => "i am cat and i dont like to run"; }

        public override string SayHello()
        {
            return "i am cat ";
        }

    }
}
