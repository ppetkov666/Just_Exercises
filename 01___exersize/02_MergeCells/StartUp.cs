namespace _2_MergeCells
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    class StartUp
    {
        static void Main()
        {
            var first = File
                .ReadAllText("FileOne.txt")
                .Split(new string[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var second = File
                .ReadAllText("FileTwo.txt")
                .Split(new string[] { " ", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<int> listcount = new List<int>();
            for (int i = 0; i < first.Length; i++)
            {
                File.AppendAllText("result.txt", first[i] + "\r\n" + second[i] + "\r\n");

            }
        }
    }
}