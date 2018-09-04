namespace EventExampleTask
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher
    {
        public event EventHandler StartTalking;

        public string Name { get; set; }
        public void ClassBegin()
        {
            this.StartTalking(this, EventArgs.Empty);
        }
        
    }
}