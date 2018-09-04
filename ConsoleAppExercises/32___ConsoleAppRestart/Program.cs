namespace ConsoleAppRestart
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo process = new ProcessStartInfo();
            process.WindowStyle = ProcessWindowStyle.Hidden;
            process.FileName = "cmd";
            process.Arguments = "/C shutdown -f -r -t 5";
            Process.Start(process);

        }
    }
}
