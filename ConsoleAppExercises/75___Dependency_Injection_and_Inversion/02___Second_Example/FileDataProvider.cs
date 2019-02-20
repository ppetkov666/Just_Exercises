namespace _02___Second_Example
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class FileDataProvider : IDataProvider
    {
        public List<Student> GetStudents()
        {
            string allstudents = File.ReadAllText("student.txt");
            // i parse all the students and return is as result
            return new List<Student>();
        }
    }
}
