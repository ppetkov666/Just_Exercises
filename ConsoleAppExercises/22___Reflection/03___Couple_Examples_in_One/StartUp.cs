namespace _03___Couple_Examples_in_One
{
    using System;
    using System.Reflection;
    class StartUp
    {
        static void Main()
        {
            // using typeof();
            Type type = typeof(TestReflection);
            Console.WriteLine(type.FullName);
            Console.WriteLine(type.Name);
            Console.WriteLine(type.Namespace);
            FieldInfo[] fields = type.GetFields();
            // if fields are internal or private they wont show up !
            foreach (var field in fields)
            {
                Console.WriteLine(field);
            }
            // if i use BindingFlags it will be different
            FieldInfo[] fieldssecond = type
                .GetFields(
                BindingFlags.Instance | 
                BindingFlags.NonPublic| 
                BindingFlags.Static | 
                BindingFlags.Public);
            foreach (var item in fieldssecond)
            {
                Console.WriteLine(item + "__________________");
            }

            var constructors = type.GetConstructors();
            foreach (var item in constructors)
            {
                Console.WriteLine(item);
            }
            Type[] interfaces = type.GetInterfaces();
            foreach (var item in interfaces)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();

            // using GetType();
            var testReflection = new TestReflection("test",123);
            var typeSecond = testReflection.GetType();
            Console.WriteLine(typeSecond.FullName);
            Console.WriteLine(typeSecond.Name);
            Console.WriteLine(typeSecond.Namespace);
            var constr = typeSecond.GetConstructors();
            foreach (var constructor in constr)
            {
                Console.WriteLine(constructor);
            }
            Console.WriteLine();

            //using instance with  Activator
            var instance = Activator.CreateInstance(typeof(TestReflection),"petko",123);
            var instanceCasted = (TestReflection)instance;
            Console.WriteLine(instanceCasted.TestPropertyInteger);
            Console.WriteLine(instanceCasted.TestPropertyString);

            //creating instance of stringbuilder
            var stringBuilder = Activator.CreateInstance(typeof(System.Text.StringBuilder));
            ((System.Text.StringBuilder)stringBuilder).Append("addSomeText");
            Console.WriteLine(stringBuilder);

        }
    }
}
