namespace _01___First_Example
{
    using System;
    class Program
    {
        static void Main()
        {
            var objectTest = new object();
            var cat = new Cat();
            var gettypeOfCat = cat.GetType();

            

            foreach (var prop in gettypeOfCat.GetProperties())
            {
                Console.WriteLine(prop.Name + " " + prop.PropertyType.Name);
            }
            Console.WriteLine(typeof(Animal).Name);
            Type[] allInterfaces = gettypeOfCat.BaseType.GetInterfaces();
            foreach (var interF in allInterfaces)
            {
                Console.WriteLine(interF.Name);
            }
            Console.WriteLine(typeof(object).Name);
            Console.WriteLine(typeof(Object).Name);

            var baseType = gettypeOfCat.BaseType;
            while (baseType != typeof(object))
            {
                Console.WriteLine(baseType.Name);
                baseType = baseType.BaseType;
            }
        }
    }
}
