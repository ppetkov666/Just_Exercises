using System;
using static System.Console;
namespace Third_example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 56, 58, 57, 90, 92, 94, 93, 91, 45 };
            int n = arr.Length;
            FindLength(arr, n, out var maxlenth);
            WriteLine($"Length of the longest contiguous subarray is {maxlenth}");
            ReadKey();
        }

        static void FindLength(int[] arr, int n, out int maxlength)
        {
            maxlength = 1;
            for (int i = 0; i < n - 1; i++)
            {
                int mn = arr[i], mx = arr[i];
                for (int j = i + 1; j < n; j++)
                {
                    mn = min(mn, arr[j]);
                    mx = max(mx, arr[j]);
                    if ((mx - mn) == j - i)
                    {
                        maxlength = max(maxlength, mx - mn + 1);
                    }
                }
            }
        }
        static int min(int x, int y)
        {
            return (x < y) ? x : y;
        }
        static int max(int x, int y)
        {
            return (x > y) ? x : y;
        }
    }
}
