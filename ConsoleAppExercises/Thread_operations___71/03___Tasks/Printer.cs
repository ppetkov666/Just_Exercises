namespace _03___Tasks
{
    using System;
    public class Printer
    {
        public event EventHandler PrintEvent;

        public void StartPrinting()
        {
            this.PrintEvent(this, EventArgs.Empty);
        }
    }
}
