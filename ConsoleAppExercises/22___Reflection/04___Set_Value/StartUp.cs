namespace _04___Set_Value
{
    using System;
    using System.Reflection;
    class StartUp
    {
        static void Main()
        {
            TestReflection test = new TestReflection("petko");
            // we can GET the name but we cant SET the name 
            var name = test.Name;
            Console.WriteLine(name);
            // it is readOnly
            //test.Name = "John";
            //but we can set the name with REFLECTION !!

            Type testWithReflection = typeof(TestReflection);
            TestReflection reflectionTest =(TestReflection) Activator
                .CreateInstance(typeof(TestReflection),
                new object[] { "petkoReflection" });
            Console.WriteLine(reflectionTest.Name);
            var field = testWithReflection
                .GetField("name",BindingFlags.Instance | BindingFlags.NonPublic);
            field.SetValue(reflectionTest,"changedNameWIthReflection");
            Console.WriteLine(reflectionTest.Name);
        }
    }
}
