namespace _01_First_Example
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    class StartUp
    {
        public const string text = "TextFile.txt";
        static void Main(string[] args)
        {
            var nums = File.ReadAllText("../../../TextFile1.txt");
            string addNums = $"{nums}{Environment.NewLine}7 8 9 10";
            File.WriteAllText("TextFile1.txt", addNums);
            
            using (var reader = new StreamReader("TextFile1.txt"))
            {
                var firstline = reader.ReadLine();
                while (!string.IsNullOrEmpty(firstline))
                {
                    Console.WriteLine(firstline);
                    firstline = reader.ReadLine();
                }
            }

            string[] directory = Directory.GetDirectories("../../../TestDirectory");
            string[] firstSubDirectory = Directory.GetFiles(directory[0]);
            // this can be done with the File class 
            var firstfile = File.ReadAllText(firstSubDirectory[0]);
            Console.WriteLine(firstfile);
            // or it can be done with StreamReader class
            int counter = 1;
            using (var reader = new StreamReader(firstSubDirectory[0]))
            {
                var firstLine = reader.ReadLine();
                while (!string.IsNullOrEmpty(firstLine))
                {
                    
                    Console.WriteLine($"{counter.ToString("D3")} : {firstLine}");
                    firstLine = reader.ReadLine();
                    counter++;
                    
                }
            }


        }
    }
}
