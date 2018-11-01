
namespace _02___Second_Example_Event
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Button
    {
        public event EventHandler Click;
        public string Name { get; set; }
        public void Print(string name,DateTime details)
        {
            
            this.Click(new Button { Name = name}, new ButtonEventArgs { Details = details});
        }
    }
}
