using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces.cars
{
    class Mercedes : ICar
    {
        public Mercedes(string model)
        {
            this.Model = model;
        }
        public string Model { get; set; }

        public void Start()
        {
            Console.WriteLine("StartTheEngine");
        }

        public void Stop()
        {
            Console.WriteLine("Stop The Engine");
        }
    }
}
