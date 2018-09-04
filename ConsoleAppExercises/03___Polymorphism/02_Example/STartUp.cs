namespace Second_Example
{
    using System;
    using System.Collections.Generic;
    class STartUp
    {
        static void Main(string[] args)
        {
            IAnimal cat = new Cat();
            Console.WriteLine(cat.Reproduce());
            var person = (Person)cat;
            person.Age = 33;
            Console.WriteLine(person.Age);
            var list = new List<IAnimal>();
            list.Add(new Person { Age = 22});
            list.Add(new Cat { Name = "Garfild"});
            foreach (var listMembers in list)
            {
                var age = ((Person)listMembers).Age;
               // i can cast cat to a person but not person to cat 
               //var name = ((Cat)listMembers).Name;
               //Console.WriteLine(name);
                Console.WriteLine(listMembers.Reproduce());
                Console.WriteLine(age);
                
                
            }
        }
        public interface IAnimal
        {
            
            string Reproduce();
        }
        public class Person : IAnimal
        {
            public int Age { get; set; }
            public virtual string Reproduce()
            {
                return "i am reproducing";
            }


        }
        public class Cat : Person
        {
            public string Name { get; set; }
            public override string Reproduce()
            {
                return "i am a cat";
            }

        }
    }
}

