namespace _02___Second_Example
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class DataBase : IDataProvider
    {
        public List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student{ Name = "petko" , Age = 30},
                new Student{ Name = "ivan" , Age = 31},
                new Student{ Name = "georgi" , Age = 33}
            };
        }
    }
}
