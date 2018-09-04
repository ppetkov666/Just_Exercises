using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Same_Task_But_Solved_With_Classes
{
    public class Person
    {
        public string Name { get; set; }
        public HashSet<string> Cards { get; set; }
        public int Points { get; set; }

        public Person()
        {
            this.Cards = new HashSet<string>();
        }
    }
}
