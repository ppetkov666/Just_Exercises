namespace _3_Try_Catch_Important_Task
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    class StartUp
    {
        static Dictionary<char, string> keybindings = new Dictionary<char, string>();
        static void Main(string[] args)
        {
            try
            {
                ReadSetttings();
            }
            catch (FileNotFoundException)
            {

                Console.WriteLine("can't find the file.Reverting to defaults");
                keybindings['w'] = "move up";
                keybindings['s'] = "move down";
                keybindings['a'] = "move left";
                keybindings['d'] = "move right";
            }

            bool finished = true;
            while (finished)
            {
                char input = ReadInput();
                finished = HandleInput(input);
            }
        }
        private static bool HandleInput(char input)
        {
            if (input == 'e')
            {
                Console.WriteLine("sorry try again later");
                return false;
            }
            else
            {
                try
                {
                    Console.WriteLine(keybindings[input]);
                }
                catch (KeyNotFoundException)
                {

                    Console.WriteLine("enter another key : w,s,a or d");
                }

            }
            return true;
        }

        private static char ReadInput()
        {

            return Console.ReadLine()[0];
        }

        private static void ReadSetttings()
        {
            string[] settingLines = File.ReadAllLines("settings.txt");
            foreach (var line in settingLines)
            {
                string[] setting = line
                    .Split(new string[] { " = " }, StringSplitOptions.RemoveEmptyEntries);
                keybindings[setting[0][0]] = setting[1];
            }
        }
    }
}
