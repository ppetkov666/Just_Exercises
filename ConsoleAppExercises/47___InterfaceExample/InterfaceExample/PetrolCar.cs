﻿namespace InterfaceExampleTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class PetrolCar : Car
    {
        public PetrolCar(string name, string engine) : base(name, engine)
        {
        }
       public override void Start()
       {
           Console.WriteLine($"I am {this.Name} Car with {this.Engine} Engine");
       }
    }
}