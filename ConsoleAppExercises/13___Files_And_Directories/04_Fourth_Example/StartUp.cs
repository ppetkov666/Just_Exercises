namespace _04_Fourth_Example
{
    using System;
    using System.IO;
    using System.Text;

    class StartUp
    {
        static void Main()
        {
            var textMessage = "textMessage";
            FileStream stream = null;
            try
            {
                stream = new FileStream("../../../output.txt",FileMode.Create);
                var cyrilicBytes = Encoding.UTF8.GetBytes(textMessage);
                stream.Write(cyrilicBytes, 0, 11);

            }
            finally 
            {
                stream.Close();
                
            }
        }
    }
}
