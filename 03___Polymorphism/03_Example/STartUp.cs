namespace Lecture_Notes_and_Examples
{
    using System;
    using System.Collections.Generic;
    class STartUp
    {
        static void Main()
        {
            var listOFnums = new int[]
            {
                    2,
                    3,
                    4,
                    5,
                    6,
                    7
            };
            var iReadOnly = (IReadOnlyCollection<int>)listOFnums;

            PrintNUmbers(listOFnums);

        }
        public static void PrintNUmbers(IEnumerable<int> nums)
        {
            foreach (var number in nums)
            {
                Console.WriteLine(number);
            }
        }
        public class Person
        {
            public override string ToString()
            {
                return base.ToString();
            }
        }
    }
}
