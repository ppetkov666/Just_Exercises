
namespace _03___Third_event_example
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Keyboard : MacComputer
    {
        public override string Model { get => base.Model; set => base.Model = value; }
        //public override string Name { get => base.Name; set => base.Name = value; }
        public override void Comp_PrepareDeviceToInstall(object sender, EventArgs e)
        {
            base.Comp_PrepareDeviceToInstall(new Keyboard { Model = base.Model}, e);
        }
       
    }
}
