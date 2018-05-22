namespace _05_GroupBy_Examples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public const string Template = "--------------------Next_Example-------------------";
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------Couple of Examples in One Task--------------------");
            var studentList = new List<Student>()
            {new Student
            {
                Id = 1,
                FirstName = "John",
                LastName = "Lennon",
                Age = 44,
                Marks = new List<int>{2,3,4,5,6},
                CourseId = 1
            },
            new Student
            {
                Id = 2,
                FirstName = "Ivan",
                LastName = "ivanov",
                Age = 33,
                Marks = new List<int>{6,5,4,3,2},
                CourseId = 2

            },
            new Student
            {
                Id = 3,
                FirstName = "Peter",
                LastName = "Bronson",
                Age = 23,
                Marks = new List<int>{6,6,6,6,6},
                CourseId = 3
             },
            new Student
            {
                Id = 4,
                FirstName = "Brad",
                LastName = "Pitt",
                Age = 45,
                Marks = new List<int>{2,2,2,2,2},
                CourseId = 4
            }
            };
            var firstCourse = new Course(1, "c#");
            var secondCourse = new Course(2, "java");
            var thirdCourse = new Course(3, "c++");
            var fourthCourse = new Course(4, "python");
            var listOfCourses = new List<Course>();
            listOfCourses.Add(firstCourse);
            listOfCourses.Add(secondCourse);
            listOfCourses.Add(thirdCourse);
            listOfCourses.Add(fourthCourse);

            var joinedByCourse = studentList.Join
                (listOfCourses,
                s => s.CourseId,
                c => c.Id,
                (s, c) =>
                new
                {
                    StudentName = s.FirstName +" " +  s.LastName,
                    CourseName = $"---Course ID: {c.Id} {Environment.NewLine}---Course Name: {c.Name}"
                }
                );
            foreach (var item in joinedByCourse)
            {
                Console.WriteLine(item.StudentName + " ");
                Console.WriteLine(item.CourseName);
            }
            Console.WriteLine(Template);
            var listASDictionary = studentList.ToDictionary(d => d.Id);
            foreach (var item in listASDictionary)
            {
                Console.WriteLine(item.Key);
                Console.Write(item.Value.FirstName + " ");
                Console.Write(item.Value.LastName + " ");
                Console.Write(item.Value.Age );
                Console.WriteLine();
            }
            Console.WriteLine(Template);
            var groupedAsDics = studentList
            .GroupBy(s => s.Id)
            .ToDictionary(s => s.Key);
            foreach (var item in groupedAsDics)
            {
                Console.WriteLine(item.Key);
                foreach (var innerItem in item.Value)
                {
                    Console.WriteLine($"-- {innerItem.LastName}");
                }
            }

            Console.WriteLine(Template);
            var groupedElements = studentList.GroupBy(n => n.FirstName).ToList();
            foreach (var group in groupedElements)
            {
                Console.WriteLine($"GroupName: {group.Key} ");
                foreach (var item in group)
                {
                    Console.WriteLine($"ItemInsideTheGroup: {item.FirstName}");
                }
            }
            Console.WriteLine(Template);
            var selectedMarks = studentList.SelectMany(s => s.Marks).ToList();
            
            foreach (var item in selectedMarks)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(Template);
            var selectedAverageMarks = studentList.Select(s => s.AverageMarks).ToList();
            foreach (var item in selectedAverageMarks)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine(Template);
            var arrayFirst = new int[] { 3, 6, 9, 12, 15, 18 };
            var arraySecond = new int[] { 3, 6, 9, 12, 15, 18 };
            var result = arrayFirst.Zip(arraySecond, (a, b) => (a + b)).ToArray();
            
                Console.WriteLine(string.Join(",",result));
            
            // this is another way of printing with ","
            for (int i = 0; i < result.Length; i++)
            {
                var number = result[i];
                var comma = ",";
                if (i == result.Length-1)
                {
                    Console.Write(number);
                }
                else
                {
                    Console.Write($"{number}{comma}");
                }
                
            }
            Console.WriteLine();
            Console.WriteLine(Template);
            // and ... another way of printing with ","
            var isTrue = true;
            for (int i = 0; i < result.Length; i++)
            {
                var number = result[i];
                if (!isTrue)
                {
                    Console.Write(',');
                    Console.Write(number);
                   
                }
                else
                {
                    Console.Write(number);
                    isTrue = false;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine(Template);

        }
    }
}
