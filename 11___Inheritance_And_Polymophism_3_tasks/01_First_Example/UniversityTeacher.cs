
namespace _01_First_Example
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class UniversityTeacher :Teacher
    {
        private string privateUniversityTeacherName;
        protected string protectedUniversityTeacherName;
        public string publicUniversityTeacherName;
        public UniversityTeacher(int age):base(age)
        {
            var x = this.age;
        }
        public void TestInheritance()
        {
            
            
        }
        public override string SayHello()
        {
            return "i am the best UTeacher";
        }
    }
}
