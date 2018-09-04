using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_and_PolyMorph
{
    public abstract class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Legs { get; set; }
        public virtual string MakeSound()
        {
            return "i am animal , my type is";
        }
        public void Eat()
        {
            Console.WriteLine("nice food");
        }
        
        public virtual string Print()
        {
            return $"I am the best {GetType().Name}";
        }
        public abstract string Run();
    }
}
