namespace _05_FileStream_Example
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream reader = new FileStream("C:\\Users\\predator\\Desktop\\pic.jpg", FileMode.Open))
            {
                using (FileStream writer = new FileStream("copyPIC.jpg",FileMode.Create))
                {
                    var buffer = new byte[4096];
                    while (true)
                    {
                        var sourceReader = reader.Read(buffer, 0, buffer.Length);
                        if (sourceReader == 0)
                        {
                            break;
                        }
                        writer.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
}
