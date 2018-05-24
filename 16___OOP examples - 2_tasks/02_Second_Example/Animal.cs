using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Second_Example
{
    class Animal
    {
        public string name;

        public Animal(string name)
        {
            this.name = name;
        }
        protected string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
