namespace _02_Second_Example
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher("vegas");
            var employee = new Employee("sofia");
            Student student = new Student("Tokio");

            // this cast is valid 
            Person person = new Student("city");
            Student castedPerson = (Student)person;
            Console.WriteLine(castedPerson.studentInfo);
            // this cast will throw an exception 
           //Person person1 = new Person("city");
           //Student castedPerson1 = (Student)person1;
           //Console.WriteLine(castedPerson1.studentInfo);

            PrintPersonAddress(teacher);
            PrintPersonAddress(employee);
            PrintPersonAddress(student);
            PrintPersonaAddressWithInheritance(teacher);
            PrintPersonaAddressWithInheritance(employee);
            PrintPersonaAddressWithInheritance(student);

        }
        public static void PrintPersonaAddressWithInheritance(Person person)
        {
            Console.WriteLine(person.address);
        }
        public static void PrintPersonAddress(object person)
        {
            if (person is Teacher)
            {
                var teacher = (Teacher)person;
                Console.WriteLine(teacher.address);
                
            }
            else if (person is Employee)
            {
                var employee = (Employee)person;
                Console.WriteLine(employee.address);
            }
            else if (person is Student)
            {
                var student = (Student)person;
                Console.WriteLine(student.address);
            }
        }
    }
}
