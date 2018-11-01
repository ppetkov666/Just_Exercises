
namespace _02___Second_Example_Event
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Engine
    {
        public void Run()
        {
            Button button = new Button();
            button.Click += Button_Click;
            var input = Console.ReadLine();

            if (input == "enter")
            {
                button.Print(input,DateTime.Now);
            }
            else if (input == "cancel")
            {
                button.Print(input,DateTime.Now);
            }
            else
            {
                button.Print(input,DateTime.Now);
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button b = sender as Button; 
            ButtonEventArgs bea = e as ButtonEventArgs;
            Console.WriteLine($"The input is {b.Name.ToUpper()} and i am printing this message at {bea.Details}");
        }
    }
}
