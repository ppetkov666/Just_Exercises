namespace ExampleFirst
{
    using System;
    using System.Linq;
    using System.Text;
    class StartUp
    {
        static void Main()
        {
            // this is encoding for Kirilitza 
            Console.OutputEncoding = Encoding.UTF8;
            // example for polymophism
            Animal animal = new Cat("Tomas", 10, 5);
            Console.WriteLine(animal.Name);
            Console.WriteLine(animal.Age);
            Console.WriteLine(((Cat)animal).WhiskersLenght);
            Console.WriteLine(animal.SayHello());


            // example for multiple parameters 
            Console.WriteLine(Add(5, 6));
            Console.WriteLine(Add(5, 6, 7));
            Console.WriteLine(Add(5, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6));
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        // this is how to take "unlimited" numbers of parameters 
        public static double Add(params double[] numbers)
        {
            double sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }
        //this is the other way to take params 
        public static double AddParams(params double[] numbers)
        {
            return numbers.Sum();
        }
    }
    public abstract class Animal
    {
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.IsAlive = true;

        }
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Argument cannot be null");
                }
                name = value;
            }
        }

        public int Age { get; set; }
        public bool IsAlive { get; set; }
        public virtual string SayHello()
        {
            return $"I am {this.Name}, {this.Age} years old and i am {this.IsAlive}";
        }
    }
    public class Cat : Animal
    {

        public Cat(string name, int age, int whiskersLenght)
            : base(name, age)
        {
            this.WhiskersLenght = whiskersLenght;
        }

        public int WhiskersLenght { get; set; }
        public override string SayHello()
        {
            return $"Hello i am a Cat!";
        }
    }



}