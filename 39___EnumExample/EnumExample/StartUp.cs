namespace MyNamespace
{
    using System;
    using System.Data;
    using NextExample;
    
    
    public class StartUp
    {
        public static void Main()
        {
            var colors = Enum.GetValues(typeof(Color));
            var days = colors.GetValue(1);
            Console.WriteLine(days + "---");
            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }

            var day = Color.Monday | Color.Tuesday;
            if (day.HasFlag(Color.Wednesday))
            {
                Console.WriteLine("yes");
            }
            
        }
    }
}