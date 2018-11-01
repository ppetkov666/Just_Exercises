
namespace _03___Third_event_example
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    

    public class MacComputer
    {
        public event EventHandler PrepareDeviceToInstall;

        public string MessageType;
        public virtual string Model { get; set; } = "Not entered";
        public string Name { get; set; } = "Default Name";
        public void StartInstallation(string name, DateTime date)
        {
            this.PrepareDeviceToInstall(new MacComputer { Name = name }, new MacComputerArgs { time = date });
        }
        public virtual void SetInstallOn(MacComputer comp)
        {
            comp.PrepareDeviceToInstall += Comp_PrepareDeviceToInstall;
        }

        public virtual void Comp_PrepareDeviceToInstall(object sender, EventArgs e)
        {
            MacComputer mac = sender as MacComputer;
            MacComputerArgs mca = e as MacComputerArgs;
            Console.WriteLine($"I am installing {this.GetType().Name}, the model is {mac.Model} on the {mac.Name} at {mca.time}");
        }
    }
}
