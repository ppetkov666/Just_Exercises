using System;

namespace myTemplateClass
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var mytemplate = new MyTemplateClass<int>();
            mytemplate.Add(5);
            mytemplate.Add(5);
            mytemplate.Add(5);
            var news = mytemplate[2];
            Console.WriteLine(news);
            Console.WriteLine(mytemplate.Count);

        }
    }
}
