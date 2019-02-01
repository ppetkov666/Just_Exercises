namespace Thread_operations
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    public class StartUp
    {
        static void Main(string[] args)
        {
            //Parallel.For (0, 21, (i) =>
            //  {
            //      Console.WriteLine(i);
            //  });

            Parallel.For(0, 21, (i, loopState) =>
            {
                if (i == 10)
                {
                    loopState.Break();
                }
                // upper Break function actually set LowestBreakIteration = 10  
                if (i > loopState.LowestBreakIteration)
                {
                    return;
                }
                Console.WriteLine(i);
            });

            Console.WriteLine("---second example---");

            List<int> numbers = new List<int>() { 1, 4, 6, 8, 9, -1,4 };

            Parallel.For(0, numbers.Count, (i, loopState) =>
            {
                if (numbers[i] == 4)
                {
                Console.WriteLine($"number: {numbers[i]} is found at index {i}");
                    loopState.Break();
                }
            });
            //FlipImages("imagesToFlip", "flippedImages");
        }

        private static void FlipImages(string source, string destination)
        {
            var filesInDirectory = Directory.GetFiles(source);

            Parallel.ForEach(filesInDirectory, (currentFile)=> 
            {
                string fileName = Path.GetFileName(currentFile);
                Console.WriteLine($"Processing {fileName} on thread {Thread.CurrentThread.ManagedThreadId}");
                Image img = new Bitmap(fileName);
                img.Save(destination);
                var image = new Bitmap(fileName);
                image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                image.Save(Path.Combine(destination, fileName));
            });
        }
    }
}
