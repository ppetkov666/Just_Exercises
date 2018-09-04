using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_and_PolyMorph
{
    public class Dog : Animal
    {
        public override string MakeSound()
        {
            return $"{base.MakeSound()} {nameof(Dog)}";
        }
        public override string Print()
        {
            return base.Print();
        }
        public override string Run()
        {
            return "i am not running";
        }
    }
}
