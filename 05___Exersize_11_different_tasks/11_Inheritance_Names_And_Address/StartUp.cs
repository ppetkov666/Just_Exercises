namespace Inheritance_Names_And_Address
{
    using System;
    class StartUp
    {
        
        static void Main()
        {
            var teacher = new Teacher("sofia","ivanov");
            var employee = new Employee("varna","petkov");
            var student = new Student("Bourgas","petkanov");
           
            
            PrintPersontAddess(teacher);
            PrintPersontAddess(employee);
            PrintPersonName(student);        }
        static void PrintPersontAddess(Person person)
        {
            
                Console.WriteLine(person.address);
            
        }
        static void PrintPersonName(Person person)
        {

            Console.WriteLine(person.name);

        }
    }


}