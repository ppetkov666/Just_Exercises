using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public abstract class Animal:IAnimal
    {
        private string name;
        private int age;
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
                
        }
        public virtual string SayHello()
        {
            return "i am Animal";
        }

        public string Jump()
        {
            return "I like to jump";
        }

        public abstract string Run { get; }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Not Long Enough");
                }
                name = value;
            }
        }
        

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Not born yet");
                }
                age = value;
            }
        }

        public int Eyes { get => 2; set => throw new NotImplementedException(); }
    }
}
