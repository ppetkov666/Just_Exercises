using System;

namespace AbstractionAndInterfaces.Animals
{
    public class Cat : Animal
    {

        public override string SayHello()
        {
            return base.SayHello() + "Myau";
        }
    }
}
