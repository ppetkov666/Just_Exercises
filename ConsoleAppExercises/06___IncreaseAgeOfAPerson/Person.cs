namespace IncreaseAgeOfaPerson
{
    class Person
    {
        private int age;
        public Person(int age)
        {
            this.Age = age;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person IncreaseAgeByOneYear()
        {
            age++;
            return this;
        }
        public string TimeToRetire()
        {
            return "It is time for pension";
        }
        public void Print()
        {
            System.Console.WriteLine($"Person Age is: {age} !");
        }
    }
}