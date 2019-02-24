namespace File_name_changer
{
    using System.IO;
    public class Program
    {
        public const string Pattern = "___";
        static void Main(string[] args)
        {
            string path = @"C:\Users\user\Desktop\Just_Exercises\ConsoleAppExercises";


            string[] folders = Directory.GetDirectories(path);

            for (int i = 0; i < folders.Length; i++)
            {
                string name = folders[i];
                string folderName = Path.GetFileName(name);
                string clearName = folderName.Substring(5);
                string add = folderName.Substring(0,2);
                string newName = clearName + Pattern + add;
                int lenght = name.Length - folderName.Length;
                string dir = name.Substring(0, lenght);
                string newdir = dir + newName;
                Directory.Move(name, newdir);
            }
        }
    }
}
