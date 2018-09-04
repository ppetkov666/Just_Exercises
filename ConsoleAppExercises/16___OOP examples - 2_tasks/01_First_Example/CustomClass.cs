namespace _01_First_Example
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class CustomClass
    {
        private string name;
        private int age;
       //public CustomClass()
       //{
       //
       //}
        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }
        public int Age
        {
            get { return this.age;}
           //set
           //{
           //    age = value;
           //}
        }
        public bool SetAge(int newAge)
        {
            this.age = newAge;
            var ageIsvalid = IsAgeVald(this);
            return ageIsvalid;
        }
        public static bool IsAgeVald(CustomClass person)
        {
            return person.age >= 0;
        }
        public CustomClass IncreaseAgeByOne()
        {
            this.age++;
            return this;
        }
        public void Print()
        {
            Console.WriteLine($"The person is {age} years old");
        }
        public void PrintIncreasedYears()
        {
            Console.WriteLine($"The person became one year older - {age}");
        }
           
    }
}
