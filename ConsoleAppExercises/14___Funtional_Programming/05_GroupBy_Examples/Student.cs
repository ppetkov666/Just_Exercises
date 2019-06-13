namespace _05_GroupBy_Examples
{
    using System.Collections.Generic;
    using System.Linq;

    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double AverageMarks => this.Marks.Average();
        public int Age { get; set; }
        public List<int> Marks { get; set; }
        public int CourseId { get; internal set; }
    }
}
