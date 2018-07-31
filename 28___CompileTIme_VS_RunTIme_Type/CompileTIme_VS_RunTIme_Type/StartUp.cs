namespace CompileTIme_VS_RunTIme_Type
{
    using System;

    class Animal { }
    class Dog : Animal { }
    class Cat : Animal { }
    class StartUp
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();

            // compiler does not know that that the dog is really dog
            //all it knows it is a Animal and that's why cant compile
            //Dog realDog = dog;
            //Cat realCat = cat;

            // if we want the program to start we have to cast the dog and the cat
            // explicitly 

            // in this case it is easy because we see it 
            Dog realDog = (Dog)dog;
            Cat realCat = (Cat)cat;

            // but in this case it will be compile time Error
            // because we have no idea what will be runtime cat or dog 
            var random = new Random();

            var randy = random.Next();
            bool isTrue = randy % 2 == 0;

            Animal animal = isTrue ? (Animal)new Dog() : (Animal)new Cat();

            var realNewDog = (Dog)animal;
        }
    }
}
