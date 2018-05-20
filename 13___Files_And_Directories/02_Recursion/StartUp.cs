namespace _02_Recursion
{
    using System;
    using System.IO;
    class StartUp
    {
        static void Main()
        {
            TraverseDirectory("../../../FirstTestFolder");
        }
        public static void TraverseDirectory(string directory)
        {

            string[] alldirectories = Directory.GetDirectories(directory);
            var name = Path.GetFileName(directory);

            Console.WriteLine($"Directory: {name}");
            string[] files = Directory.GetFiles(directory);
            foreach (var file in files)
            {
                var fileContent = File.ReadAllText(file);
                Console.WriteLine(file);
                Console.WriteLine(fileContent);
            }
            foreach (var dir in alldirectories)
            {
                TraverseDirectory(dir);
            }
            // how to generate random string and put it into a file !
            using (var writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < 1000; i++)
                {
                    writer.WriteLine(Guid.NewGuid().ToString());
                }
            }
        }

    }
}
