namespace _07_TCP_Listener
{
    using System;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;

    class StartUp
    {
        public const int PortNumber = 1337;
        static void Main()
        {
            var tcpListener = new TcpListener(IPAddress.Any, PortNumber);
            tcpListener.Start();
            Console.WriteLine($"Listening on port {PortNumber}...");
            while (true)
            {
                using (NetworkStream stream = tcpListener.AcceptTcpClient().GetStream())
                {
                    var byterequest = new byte[4096];
                    int readbytes = stream.Read(byterequest, 0, 4096);
                    Console.WriteLine(Encoding.UTF8.GetString(byterequest,0,readbytes));

                    string html = string.Format("HTTP/1.1 200 OK\nContent-Type:text\n\n"
                        + "{0}{1}{2}{3}<br>{4}{2}{1}{0}",
                        "<html>","<body>","<h1>","Welcome to my awesome site !",
                        DateTime.Now);

                    var htmlBytes = Encoding.UTF8.GetBytes(html);
                        stream.Write(htmlBytes, 0, html.Length);
                }
            }

        }
    }
}
