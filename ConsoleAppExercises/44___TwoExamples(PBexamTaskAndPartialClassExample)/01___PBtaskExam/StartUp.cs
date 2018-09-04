using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PBTaskExam
{
    class StartUp
    {
        public const string Template = "32656";
        public const int ArrayLenght = 22;
        public const int DistanceToWordLenght = 4;
        public const int DistancetoSearchedWord = 6;
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            var wordLenght = -1;
            var founded = false;
            var oldI = 0;
            var wordList = new List<byte>();
            while (input != "Visual Studio crash")
            {
                var splitedInput = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                
                for (int i = 0; i < splitedInput.Length; i++)
                {

                    if (splitedInput[i].Contains(Template))
                    {
                        var maxLenght = i + DistanceToWordLenght;
                        if (maxLenght < ArrayLenght)
                        {

                            if (i + DistancetoSearchedWord >= ArrayLenght)
                            {
                                
                                wordLenght = int.Parse(splitedInput[i + DistanceToWordLenght]);
                                oldI = i + DistancetoSearchedWord - ArrayLenght;
                                founded = true;
                                break;
                            }
                            wordLenght = int.Parse(splitedInput[i + DistanceToWordLenght]);
                            var beggining = i + DistancetoSearchedWord;
                            var end = i + DistancetoSearchedWord + wordLenght;
                            if (end >= ArrayLenght)
                            {
                                end = ArrayLenght;
                                for (int a = beggining; a < end; a++)
                                {
                                    wordList.Add(byte.Parse(splitedInput[a]));
                                    wordLenght--;
                                }
                                 
                                oldI = 0;
                                founded = true;
                                break;
                            }
                            for (int a = beggining; a <= end; a++)
                            {
                                wordList.Add(byte.Parse(splitedInput[a]));
                            }
                            var arrayList = wordList.ToArray();
                            char[] letter1 = Encoding.ASCII.GetChars(arrayList);
                            Console.WriteLine(string.Join("", letter1));
                            wordList.Clear();
                            break;
                        }
                        
                        else
                        {
                            oldI = i + DistancetoSearchedWord - ArrayLenght;
                            
                            founded = true;
                            break;
                        }
                    }
                    else if (founded)
                    {
                        var beggining = oldI ;
                        if (wordLenght != -1)
                        {
                            var end = beggining + wordLenght;
                            for (int a = beggining; a < end; a++)
                            {
                                wordList.Add(byte.Parse(splitedInput[a]));
                            }
                            var arrayList = wordList.ToArray();
                            char[] letter1 = Encoding.ASCII.GetChars(arrayList);
                            Console.WriteLine(string.Join("", letter1));
                            wordList.Clear();
                            founded = false;
                            wordLenght = -1;
                        }
                        else
                        {
                            wordLenght = int.Parse(splitedInput[oldI - 2]);
                            var end = beggining + wordLenght;
                            for (int a = beggining; a < end; a++)
                            {
                                wordList.Add(byte.Parse(splitedInput[a]));
                            }
                            var arrayList = wordList.ToArray();
                            char[] letter1 = Encoding.ASCII.GetChars(arrayList);
                            Console.WriteLine(string.Join("", letter1));
                            wordList.Clear();
                            founded = false;
                            wordLenght = -1;

                        }
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
