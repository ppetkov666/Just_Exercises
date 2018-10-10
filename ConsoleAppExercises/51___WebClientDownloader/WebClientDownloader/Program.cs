using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;


namespace WebClientDownloader
{
    class SyncResourseAccessProblems
    {
        static string websiteHtml = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Web address");
            string url = Console.ReadLine();
            GetWebSiteHTML(url);
            while (true)
            {
                Console.WriteLine(@"Press ""print"" to show the content or press ""escape"" to exit");
                string userInput = Console.ReadLine();
                if (userInput == "print")
                {
                    Console.WriteLine(websiteHtml);
                    
                }
                else if (userInput == "escape")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Command not recognized Try again !");
                }
            }


        }

        private static void GetWebSiteHTML(string url)
        {
            WebClient client = new WebClient();
            websiteHtml = client.DownloadString(url);
            Console.WriteLine("Loading...");
            Thread.Sleep(5000);
            
        }
    }
}
