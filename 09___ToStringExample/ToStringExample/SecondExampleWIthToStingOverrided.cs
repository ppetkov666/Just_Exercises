namespace ToStringExample
{
    class SecondExampleWIthToStingOverrided
    {
        private string name;
        private int age;

        public SecondExampleWIthToStingOverrided(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public override string ToString()
        {
            return $"I am {this.Name}  and i am {this.Age} old !";
        }
    }
}
