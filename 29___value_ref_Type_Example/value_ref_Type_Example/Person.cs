namespace example
{
    class Person
    {
        public Person spouse;
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            // this is a great example for stackOverflow Exception
            //this.spouse = new Person(string.Empty,0);
        }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
