using System;
using AbstractionAndInterfaces.Animals;
namespace AbstractionAndInterfaces.Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public virtual string SayHello()
        {
            Validator.CheckForNull(this.Name, nameof(Name));
            return "Hello I am ";
        }
        
    }
}
