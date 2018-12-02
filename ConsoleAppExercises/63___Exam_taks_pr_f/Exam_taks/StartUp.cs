using System;
using System.Collections.Generic;
using System.Linq;
namespace Exam_taks
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoViews = new Dictionary<string, int>();
            var videoLikes = new Dictionary<string, int>();

            string input = Console.ReadLine();
            while (true)
            {
                if (input == "stats time")
                {
                    break;
                }
                if (input.Contains(":"))
                {
                    string[] inputArgs = input.Split(":").ToArray();
                    string comment = inputArgs[0];
                    string name = inputArgs[1];

                    if (videoLikes.ContainsKey(name))
                    {
                        videoLikes[name] = comment == "like" ? videoLikes[name] += 1 : videoLikes[name] -= 1;

                    }
                    
                }
                if (input.Contains("-"))
                {
                    string[] inputArgs = input.Split("-").ToArray();
                    string name = inputArgs[0];
                    int views = int.Parse(inputArgs[1]);

                    if (!videoViews.ContainsKey(name))
                    {
                        videoViews.Add(name, views);
                        videoLikes.Add(name, 0);
                    }
                    else
                    {
                        videoViews[name] += views;
                    }
                }
                input = Console.ReadLine();
            }
            string orderCriteria = Console.ReadLine();
            if (orderCriteria == "by likes")
            {
                videoViews = videoViews.OrderByDescending(x => videoLikes[x.Key])
                                       .ToDictionary(x => x.Key, x => x.Value);
                foreach (var videos in videoViews)
                {
                    Console.Write($"{videos.Key} - {videos.Value} views - ");

                    var something = videoLikes.FirstOrDefault(x => x.Key == videos.Key).Value;
                    Console.WriteLine($"{something} likes");
                }
            }
            else
            {
                foreach (var video in videoViews.OrderByDescending(x => x.Value))
                {
                    Console.Write($"{video.Key} - {video.Value} views - ");

                    var something = videoLikes.FirstOrDefault(x => x.Key == video.Key).Value;
                    Console.WriteLine($"{something} likes");
                }
            }


        }
    }
}
