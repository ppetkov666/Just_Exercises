namespace _02___Second_Example
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class RandomProvider : IRandomNumberProvider
    {
        //wrap this class Random in RandomProvider into Interface
        private static readonly Random random = new Random();

        public int GetRandomNumber(int min = 0, int max = int.MaxValue)
        {
            return random.Next(min, max);
        }
    }
}
