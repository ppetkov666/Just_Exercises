namespace Funk_Methods
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var array = new string[] { "1", "1", "1", "1" };
            //var parsed = array.Select(s => int.Parse(s)).ToList();
            //foreach (var item in parsed)
            //{
            //    Console.WriteLine(item + 5);
            //}

            var parsed = array.Select((string text) =>
            {
                return int.Parse(text);
            }).ToList();


            Func<string, int> myCustomSelect = (test) => int.Parse(test);
            var parsedCustom = array.Select(a => myCustomSelect(a)).ToList();

            foreach (var item in parsedCustom)
            {
                Console.WriteLine(item + 7);
            }
        }

        public static int ParseNumber(string text)
        {
            return int.Parse(text);
        }
    }
}
