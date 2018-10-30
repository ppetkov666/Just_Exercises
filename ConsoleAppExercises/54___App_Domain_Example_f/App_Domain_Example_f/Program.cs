
namespace App_Domain_Example_f
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Security;
    using System.Text;
    using System.Threading.Tasks;
    using System.Security.Permissions;

    [Serializable]
    public class ThirdPartyClass
    {
        public ThirdPartyClass()
        {
            Console.WriteLine("Third party Loaded");
            File.Create(@"C:\Users\predator\Downloads\petkoTest.txt");
        }

        ~ThirdPartyClass()
        {
            Console.WriteLine("Third party UN_Loaded");

        }
    }
    public class FirstClass
    {

    }
    public class SecondClass
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            // app domain is logically isolated container
            // when application is started Windows operation System  start a process under which process default app domain is loaded
            // but in this example we will create another app domain with the following example
            PermissionSet permissions = new PermissionSet(PermissionState.None);
            permissions.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            permissions.AddPermission(new FileIOPermission(FileIOPermissionAccess.NoAccess, @"C:\Users\predator\Downloads\"));
            AppDomainSetup setup = new AppDomainSetup();
            setup.ApplicationBase = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            // secure domain runs on separate app domain than first and second class
            // it allows third party dll to run on separately isolated domain and to restrict the access as it is on the example

            // if errors are found it will be uloaded and other app domain will run separatelly
            AppDomain secureDomain = AppDomain.CreateDomain("secureDomain", null, setup, permissions);
            try
            {
                Type thirdparty = typeof(ThirdPartyClass);
                secureDomain.CreateInstanceAndUnwrap(thirdparty.Assembly.FullName, thirdparty.FullName);
            }
            catch (Exception)
            {
                Console.WriteLine("Error Found");
                AppDomain.Unload(secureDomain);
            }
            
            
            FirstClass firstClass = new FirstClass();
            SecondClass secondClass = new SecondClass();
            Console.WriteLine("Press Enter to Exit");
            Console.Read();
        }
    }
}
