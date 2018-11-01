
namespace Event_Example_task
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            
            Student firstStudent = new Student();
            Student secondStudent = new Student();
            Student thirdStudent = new Student();
            firstStudent.Name = "John";
            secondStudent.Name = "Lindsey";
            thirdStudent.Name = "Damon";
            Teacher MathTeacher = new Teacher();
            MathTeacher.Name = "Mr. Dorsel";
            firstStudent.GoToExam(MathTeacher);
            secondStudent.GoToExam(MathTeacher);
            thirdStudent.GoToExam(MathTeacher);
            MathTeacher.ExamRetake("Mr.McCarter","Monday, 31 of June, 8:00 AM");

        }
    }
    class Student
    {
        public string Name { get; set; }
        public void GoToExam(Teacher teacher)
        {
            teacher.ExamStart += Teacher_ExamStart;
        }
        private void Teacher_ExamStart(object sender, EventArgs e)
        {
            Teacher teacher = sender as Teacher;
            TeacherEventArgs examDate = e as TeacherEventArgs;
            
            Console.WriteLine($"{this.Name} is going on the exam!.His teacher is {teacher.Name}, and the exam will be on {examDate.Date} ");
        }
    }
    class Teacher
    {
        public event EventHandler ExamStart;
        public string Name { get; set; }
        public void ExamRetake(string name,string examDate)
        {
            // first option
            //Teacher t = new Teacher();
            //t.Name = name;
            // and pass it on the method as (object)t
            //second option
            //new Teacher { Name = name }
            // and this option as it is on this example with THIS
            this.ExamStart(this, new TeacherEventArgs { Date = examDate});
        }

    }
    class TeacherEventArgs : EventArgs
    {
        public string Date { get; set; }
    }

}
