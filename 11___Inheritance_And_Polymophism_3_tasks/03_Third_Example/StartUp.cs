namespace _03_Third_Example
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            // in the first example new we dont use polymorphism  just 
            // inheritance of the method GetName
            Dog dog = new Dog();
            Cat cat = new Cat();
            Console.WriteLine(dog.GetName());
            Console.WriteLine(cat.GetName());

            // in the second example here we use polymorphism
            // and also we see that the word NEW in the method of the Cat 
            // basically it is a new method and there is no polymorphism !
            Animal dogAsAnimal = new Dog();
            Animal catAsAnimal = new Cat();
            Console.WriteLine(dogAsAnimal.GetName());
            Console.WriteLine(catAsAnimal.GetName());

            // this is the same example as the second one but with static 
            //method PrintAnimal
            PrintAnimal(dogAsAnimal);
            PrintAnimal(catAsAnimal);
        }
        static void PrintAnimal(Animal animal)
        {
            Console.WriteLine(animal.GetName());
        }
    }
}
