namespace _05___Invoke_Constructor
{
    using System;
    using System.Text;
    using System.Reflection;

    class Program
    {
        static void Main()
        {
            //var sb = new StringBuilder();
            Type type = typeof(StringBuilder);
            ConstructorInfo constructor = type.GetConstructor(new Type[]{ typeof(int),typeof(int)});
            var sb = constructor.Invoke(new object[] { 5, 1000 });
            // we ca just create string array and give it as parameter
            // when we invoke the method
            string[] objectTest = new string[1];
            objectTest[0] = "petkov"; 
            MethodInfo method = type.GetMethod("Append",new Type[] { typeof(string)});
            method.Invoke(sb,objectTest);
            Console.WriteLine(method);
            Console.WriteLine(objectTest);
            Console.WriteLine(sb);
        }
    }
}
