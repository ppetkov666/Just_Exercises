namespace _01_First_Example
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Person
    {
        private string privatePersonName;
        protected string protectedPersonName;
        public string publicPersonName;
        protected int age;
        // this will be executed first !
        List<int> grades = GetGrades();
        public Person(int age)
        {

        }
        public Person(List<int> grades)
        {
            this.grades = grades;
        }
        static List<int>GetGrades()
        {
            return new List<int>();
        }
        public virtual string SayHello()
        {
            return "I am the best Person";
        }
    }
}
