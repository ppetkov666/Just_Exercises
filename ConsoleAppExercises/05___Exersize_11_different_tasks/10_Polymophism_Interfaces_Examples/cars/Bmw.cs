using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces.cars
{
    public class Bmw : ICar
    {
        public Bmw(string model)
        {
            this.Model = model;
        }
        public string Model { get; private set; }

        public new void Start()
        {
            Console.WriteLine("I am BMW and I am starting the Engine");
        }

        public void Stop()
        {
            Console.WriteLine("you have stopped the engine");
        }
    }
}
