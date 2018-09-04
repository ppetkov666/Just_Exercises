namespace _02_Second_Example
{
    using System;
    using MyTestLibrary;
    using SecondMyTestLibrary;
    using ThirdMytestLibrary;

    class StartUp
    {
        static void Main(string[] args)
        {
            // this is just a simple example for "protected" modifier
            var animal = new Animal("sheep");         
            var dog = new Dog("baddog");
            // this is just an example how we can make a stupig mistake 
            //if the field is public and we set it through a constructor
            // instead of using property !!!!!
            Console.WriteLine(animal.name);
            dog.SetName();

            // this is an example for adding reference - myTestLibrary
            // and the different protections levels
            var student = new Student();
            var student1 = new MyTestLibrary.Student();
            // this is example when we have 2 classess with the same name 
            // the default for c# in the the one into the project 
            // and the other class from myTestLibrary is "student1"
            // and that is why there is no conflict when i create just a NEW student !!!
            student1.publicField = "testStudentPublicField";

            // this is another example for conflict !!!
            var teacher = new Teacher();

        }
    }
}
