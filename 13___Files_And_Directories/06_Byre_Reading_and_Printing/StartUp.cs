namespace _06_Byte_Reading_and_Printing
{
    using System;
    using System.IO;
    using System.Text;

    class StartUp
    {
        static void Main(string[] args)
        {
            string textExample = "1T";
            byte[] bytes = Encoding.UTF8.GetBytes(textExample);
            
            using (var stream = new MemoryStream(bytes))
            {
                int counterBytes;
                while ((counterBytes = stream.ReadByte()) != -1)
                {
                    var output = (char)counterBytes;
                    Console.WriteLine(output);
                }

            }
        }
    }
}
