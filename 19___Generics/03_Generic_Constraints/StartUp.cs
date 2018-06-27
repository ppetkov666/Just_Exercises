namespace _03_Generic_Constraints
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            Scale<Cat> scale = new Scale<Cat>();
            var tom = new Cat();
            var silvester = new Cat();
            //tom.CompareTo(silvester);
            

            scale.Compare(tom, silvester);
        }

    }
    public class Scale<T>
        where T : IComparable<T>
    {
        public void Compare(T first, T second)
        {
            if (first.CompareTo(second) > 0)
            {
                Console.WriteLine($"{first.GetType().Name} is heavier than {second} ");
            }
            else
            {
                Console.WriteLine($"{GetType().} is heavier than {first} ");
            }
        }
    }
    public class Cat : IComparable<Cat>
    {
        public int CompareTo(Cat other)
        {
            return 0;
        }
    }
}
