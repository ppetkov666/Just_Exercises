
namespace consoleAppVersion
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    public class StartUp
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Directory Path:");
            string dirPath = Console.ReadLine();
            Console.WriteLine("Enter file extension:");
            string fileExtension = Console.ReadLine();
            char lastLetterOfExtension = fileExtension[fileExtension.Length - 1];
            System.IO.DirectoryInfo di = new DirectoryInfo(dirPath);

            foreach (FileInfo file in di.GetFiles())
            {
                string name = file.Name;
                if (name.EndsWith(lastLetterOfExtension))
                {
                    file.Delete();
                } 
            }

            
            List<string> files = Directory.GetFiles(dirPath).ToList();

            foreach (string file in files)
            {

                string path = Path.Combine(dirPath, Path.GetFileName(file + "." + fileExtension));
                File.Copy(file, Path.Combine(dirPath, path));
                //File.Move(file, Path.ChangeExtension(file, extension));
            }
        }
    }
}
