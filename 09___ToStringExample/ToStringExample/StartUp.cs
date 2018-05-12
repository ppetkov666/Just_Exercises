namespace ToStringExample
{
    using System;
    using System.Text;

    class StartUp
    {
        static void Main(string[] args)
        {
            var example = new ExampleClass();
            example.Name = "Petko";
            example.Age = 18;
            var toString = example.ToString();
            // first option 
            Console.WriteLine(toString);
            //second Option 
            Console.WriteLine(example);

            var secondExample = new SecondExampleWIthToStingOverrided("Petko Petkov",34);
            //first option override toString();
            var toStringeOverrided = secondExample.ToString();
            Console.WriteLine(toStringeOverrided);
            //second option override directly toString()
            Console.WriteLine(secondExample);

            var builder = new StringBuilder();
            var builderToString = builder.ToString();
            Console.WriteLine(builderToString);
            builder.Append("petko");
            builder.Append(" from");
            builder.Append(" Las Vegas");

            
        }
    }
}
