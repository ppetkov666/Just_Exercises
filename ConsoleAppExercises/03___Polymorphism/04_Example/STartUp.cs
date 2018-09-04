namespace _04_Example
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string name = "petko";
            // return the name of this variable "name"
            var nameforprint = nameof(name);
            Console.WriteLine(nameforprint);

            //return  the name of the class(string, int or...) of this variable !!
            string namesecond = name.GetType().Name;
            Console.WriteLine(namesecond);

            Type type1 = name.GetType();
            Console.WriteLine(type1);

            Type type = typeof(string);
            Console.WriteLine(type);

            // this bool literally check  is this "name" variable a string or not !
            bool nameIsString = name.GetType() == typeof(string);
            Console.WriteLine(nameIsString);
            // this can be used to check if some property in any class 
            // is string , int or something else
        }
    }
}
