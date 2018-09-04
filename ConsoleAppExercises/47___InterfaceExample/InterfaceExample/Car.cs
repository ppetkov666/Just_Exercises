namespace InterfaceExampleTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car : IStartTheEngine
    {
        public string Name { get; set; }
        public string Engine { get; set; }

        

        public Car(string name, string engine)
        {
            this.Name = name;
            this.Engine = engine;
        }

        public  virtual void Start()
        {
            Console.WriteLine($"I am {this.Name} Car");
        }
    }
}
