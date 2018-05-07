namespace ConcatTwoNames
{
    using System;
    public class Test
    {
        private string firstName;
        private string lastName;
        public Test(string firsName, string lastName)
        {
            this.FirstName = firsName;
            this.LastName = lastName;
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public bool IsValid(Test testNames)
        {
            if (char.IsUpper(testNames.firstName[0]) && char.IsUpper(testNames.lastName[0]))
            {
                return true;
            }
            return false;
        }
        public void ConcatenameTwoNames()
        {
            Console.WriteLine($"I am {this.FirstName} {this.LastName}");
        }
    }
}