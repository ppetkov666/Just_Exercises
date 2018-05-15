namespace _01_First_Example
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Teacher:Person
    {
        private string privateTeacherName;
        protected string protectedTeacherName;
        public string publicTeacherName;
        // this new age is just for the purpose of this example 
        // but it is not preffered to be used !
        public new int age;
        public Teacher(int age):base(age)
        {

        }
        public void TestTeacherInheritance()
        {
            // with base. we have access to base class Person fields 
            //base.protectedPersonName
            //base.publicPersonName

            // this is an example what access do we have with this. and base.
            var age = 20;
            int x = this.age;
            int x1 = base.age;

        }
        public override string SayHello()
        {
            return "i am the best Teacher";
        }

    }
}
