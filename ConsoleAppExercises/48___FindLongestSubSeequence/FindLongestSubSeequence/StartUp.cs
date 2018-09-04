namespace FindLongestSubSeequence
{
    using System;
    using System.Linq;
    using LongestIncreasingSubSequence;
    class StartUp
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("{0}", string.Join(" ", FindLongestSubSequence.Get(sequence)));
        }
    }
}
