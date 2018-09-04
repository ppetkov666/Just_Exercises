namespace EventExampleTask
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            var student = new Student
            {
                Name = "Ivan"
            };
            var secondstudent = new Student
            {
                Name = "George"
            };
            var thirdstudent = new Student
            {
                Name = "Michael"
            };
            var teacher = new Teacher { Name = "M-r Ivanov"};
            student.AttendClass(teacher);
            secondstudent.AttendClass(teacher);
            thirdstudent.AttendClass(teacher);
            teacher.ClassBegin();
        }
    }
}

