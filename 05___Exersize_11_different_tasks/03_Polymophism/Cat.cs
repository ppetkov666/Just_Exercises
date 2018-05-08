using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_and_PolyMorph
{
    public class Cat : Animal
    {
        public override string MakeSound()
        {
            return $"{base.MakeSound()} {nameof(Cat)}";
        }
        
        public new string Print()
        {
            return $"nice pussy {nameof(Cat)}";
        }
        public new void Eat()
        {
            Console.WriteLine("verry verry nice");
        }
        public override string Run()
        {
            return "i am Running";
        }
    }
}
