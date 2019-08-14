namespace _02___Second_Example
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Business
    {
        public IDataProvider _dataProvider;
        public IRandomNumberProvider _randomNumberProvider;


        //public Business() : this(new TestDataProvider(), new RandomProvider())
        //{

        //}
        
        //public Business(IDataProvider dataProvider)
        //{
        //    this._dataProvider = dataProvider;
        //}
        public Business(IDataProvider dataProvider, IRandomNumberProvider randomNumberProvider) //: this(dataProvider)
        {
            this._dataProvider = dataProvider;
            this._randomNumberProvider = randomNumberProvider;
        }

         
        public void VisualizeAllStudentsSecondVersion()
        {
            List<Student> students = this._dataProvider.GetStudents();
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} - {student.Age}");
            }
        }

        // dependency inversion with parameter injection
        public void VisualizeAllStudents(/*DataBase db*/ IDataProvider dataprovider)
        {
            // in this case again we create dependency
            //DataBase db = new DataBase();
            //List<Student> students = db.GetStudent();
            // and also we manipulate the db which is not good practice
            // for testing i can just create interface and to test it with simple list of students
            // in this case every class who inherit this interface can  use this method
            // i can  read the students from files , database, or just from another class
            
            List<Student> students = dataprovider.GetStudents();
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} - {student.Age}");
            }

        }

        public double RandomiseStudentOrder()
        {
            List<Student> students = _dataProvider.GetStudents();
            // in this particular case is just to demonstrate how easy is if we want return always 100 from random generator
            double randomNumber = this._randomNumberProvider.GetRandomNumber(100,100);
            // randomize students..
            // just for test purposes and simple example
            //return string.Empty;
            return randomNumber;
        }
    }
}
