namespace _02___Second_Example
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IRandomNumberProvider
    {
        // optional params
        int GetRandomNumber(int min = 0, int max = int.MaxValue);
    }
}
