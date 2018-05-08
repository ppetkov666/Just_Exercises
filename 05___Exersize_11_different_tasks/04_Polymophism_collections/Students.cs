namespace _04_Polymophism_collections
{
    using System.Collections.Generic;
    using System.Linq;
    public class Students
    {
        public Students(int studentId,string firstname,string lastname)
        {
            this.StudentID = studentId;
            this.FirstName = firstname;
            this.LastName = lastname;

            this.AllScores = new List<int>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public double Score => this.AllScores.Average();
        public List<int> AllScores { get; set; }      
        public int StudentID { get; set; }
    }
}
