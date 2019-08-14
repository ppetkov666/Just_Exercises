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
                new Student{ Name = "petkoV1" , Age = 15},
                new Student{ Name = "ivanV1" , Age = 16},
                new Student{ Name = "georgiV1" , Age = 17}
            };
        }
    }
}
