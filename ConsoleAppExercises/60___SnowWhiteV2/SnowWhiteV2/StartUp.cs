using System;
using System.Collections.Generic;
using System.Linq;

namespace SnowWhiteV2
{
    class StartUp

    {
        static void Main(string[] args)
        {
            var dwarfs = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                string[] inputs = input.Split(new string[] { " <:> " }, StringSplitOptions.RemoveEmptyEntries);
                string name = inputs[0];
                string color = inputs[1];
                int physics = int.Parse(inputs[2]);

                string colorName = color + ':' + name;
                if (!dwarfs.ContainsKey(colorName))
                {
                    dwarfs.Add(colorName, physics);
                }
                else
                {
                    dwarfs[colorName] = Math.Max(dwarfs[colorName], physics);
                }

                input = Console.ReadLine();
            }
            foreach (var d in dwarfs
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => dwarfs.Where(y => y.Key.Split(':')[0] == x.Key.Split(':')[0])
                                             .Count()))
            {
                Console.WriteLine($"({d.Key.Split(':')[0]}) {d.Key.Split(':')[1]} <-> {d.Value}");
            }
        }
    }
}
