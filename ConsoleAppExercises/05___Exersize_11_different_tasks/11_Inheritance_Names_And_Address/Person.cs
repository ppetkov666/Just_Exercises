namespace Inheritance_Names_And_Address
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Person
    {
        public string address;
        public string name;

       
        public Person(string address,string name)
        {
            this.address = address;
            this.name = name;

        }
    }
   
    class Teacher : Person
    {
        public Teacher(string address,string name)
            : base(address,name) { }
        
    }
    class Employee : Person
    {
        public Employee(string address,string name)
            : base(address,name) { }
        
    }
    class UniversityTeacher : Teacher
    {
        public UniversityTeacher(string address,string name)
            : base(address,name) { }
       
    }
    class Student : Person
    {
        public Student(string address,string name)
            : base(address,name) { }

    }
}
