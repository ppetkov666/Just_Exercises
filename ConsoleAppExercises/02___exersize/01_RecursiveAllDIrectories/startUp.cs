namespace RecursiveAllDirectories
{
    using System;
    using System.IO;

    class startUp
    {
        static void Main(string[] args)
        {
            var count = 1;
            TraverseDirectory(count, "F:/");

        }
        public static void TraverseDirectory(int count, string directory)
        {

            Console.WriteLine($"--{directory}--");
            string[] allFiles = Directory.GetFiles(directory);
            foreach (var file in allFiles)
            {

                Console.WriteLine($"N:{count}=>{file}");

                count++;
            }
            string[] allDirs = Directory.GetDirectories(directory);
            foreach (var eachDir in allDirs)
            {
                TraverseDirectory(count, eachDir);
            }
        }
    }
}
