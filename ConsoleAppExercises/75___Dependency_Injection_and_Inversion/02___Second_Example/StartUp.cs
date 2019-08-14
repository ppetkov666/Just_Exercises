namespace _02___Second_Example
{
    using System;
    using System.Collections.Generic;
    using Ninject;
    
    public class StartUp
    {
        static void Main(string[] args)
        {
            // the detailes explanation in class Bussiness where his method works with interface 
            // and every class who inherit this interface can be passed as param
            // in this particular example i pass TestdataProvider who inherit Idataprovider
            //// this is to depend on abstraction !!!
            //VisualizeAllStudents method just take IDataProvider as parameter

            //TestDataProvider testStudents = new TestDataProvider();
            //Business business = new Business();
            //business.VisualizeAllStudents(testStudents);

            //I will demonstrate dependency injection and the previous example would not work because i will pass the interface 
            // directly through the constructor - if you want to test it just comment the constructor in the Business class
            // so long story short... with dependency inversion we avoid all dependencies using Interfaces and with dependency
            // injection we pass those interfaces straight to the constructor. 
            //There are 2 other options(property and parameter injection) also but i will use 
            // contruction injection for this example and basically i give all dependencies through the constructor.
            //Business business = new Business();
            //business.VisualizeAllStudentsSecondVersion();

            //DataBase db = new DataBase();
            //Business business = new Business(db);
            //business.VisualizeAllStudentsSecondVersion();

            // demonstrate how is easy is always to return 100 !!1
            //Business business = new Business();
            //double num = business.RandomiseStudentOrder();
            //Console.WriteLine(num);


            // this example if how to work with Ninject and for thie purpose i have commented some parts of Business class, so if you want to use it
            // with previous examples it must be UN commented
            IKernel kernel = new StandardKernel();
            kernel.Bind<IDataProvider>().To<DataBase>();
            kernel.Bind<IRandomNumberProvider>().To<RandomProvider>();

            Business business = kernel.Get<Business>();
            business.VisualizeAllStudentsSecondVersion();

        }
    }
}
