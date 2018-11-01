
namespace _03___Third_event_example
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            // this is for testing purpose only to demonstrate event application, inheritance, overriding and passing params 
            
            Keyboard keyboard = new Keyboard();
            Keyboard Blackkeyboard = new Keyboard() { Model = "Black Special Edition", Name = "Example Model"};
            Keyboard Whitekeyboard = new Keyboard(); 
            Printer printer = new Printer();
            
            VideoDriver videoDrv = new VideoDriver();
            MacComputer mac = new MacComputer();

            Blackkeyboard.SetInstallOn(mac);
            Whitekeyboard.SetInstallOn(mac);
            keyboard.SetInstallOn(mac);
            printer.SetInstallOn(mac);
            videoDrv.SetInstallOn(mac);

            mac.StartInstallation("MACINTOSH",DateTime.Now);
        }
    }
}
