namespace _04_Polymophism_collections
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var firstStudent = new Students(1, "petko", "petkov");
            var secondStudent = new Students(2, "ivan", "ivanov");
            var thirdStudent = new Students(3, "georgi", "georgiev");
            var fourthStudent = new Students(4, "gosho", "goshev");
            var listOfStudents = new List<Students>();
            listOfStudents.Add(firstStudent);
            listOfStudents.Add(secondStudent);
            listOfStudents.Add(thirdStudent);
            listOfStudents.Add(fourthStudent);

            var firstCourse = new Course("c#", 1);
            var secondCourse = new Course("c++", 2);
            var thirdCourse = new Course("java", 3);
            var fourthCourse = new Course("python", 4);
            var listOfCourses = new List<Course>();
            listOfCourses.Add(firstCourse);
            listOfCourses.Add(secondCourse);
            listOfCourses.Add(thirdCourse);
            listOfCourses.Add(fourthCourse);

            var selector = listOfStudents
                .Join(listOfCourses, st => st.StudentID, c => c.ID,
                (st, c) => new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    CourseName = c.Name
                });

            foreach (var item in selector)
            {
                Console.WriteLine($"{item.FullName} - {item.CourseName}");
            }
        }
    }
}
