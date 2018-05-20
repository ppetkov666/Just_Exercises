namespace _03_Third_Example
{
    using System;
    using System.IO;

    class StartUp
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("../../../StartUp.cs"))
            {
                using (var writer = new StreamWriter("output.txt"))
                {
                    var readLines = reader.ReadLine();
                    var counter = 1;
                    while (readLines != null)
                    {
                        writer.WriteLine($"Line {counter}: {readLines}");
                        readLines = reader.ReadLine();
                        counter++;
                    }
                }
                
            }
            // this is how using actually works 
            //StreamReader readerTest = null;
            //try
            //{
            //
            //}
            //catch (Exception ex)
            //{
            //
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    if (readerTest != null && readerTest is IDisposable)
            //    {
            //        ((IDisposable)readerTest).Dispose();
            //    }
            //}
        }
    }
}
