using System;

namespace terminalPoly
{
    class Program
    {
        public static Dog DowncastFromAnimal(Animal animal) 
        {
            try
            {
                return (Dog)animal;
            } 
            catch (InvalidCastException e) 
            {
                Console.WriteLine("An exception was thrown because we tried to downcast an object based on a base class.");
                Console.WriteLine(e.Message);
                return null;
            } 
        }

        static void Main(string[] args)
        {
            Animal henry = new Animal(){
                Name= "Henry"
            };

            Horse charlie = new Horse() {
                Name = "Charlie",
                ManeColor = "Brown"
            };

            Dog rex = new Dog() {
                Name = "Rex",
                Leash = "Brown leather"
            };


            // Example of using static properties
            Console.WriteLine("Animal Population: " + Animal.Population);
            Console.WriteLine("Horse Population: " + Horse.HorsePopulation);

            // Example of polymorphism--charlie is of type "Horse"
            // and it can be passed into the static method that 
            // accepts an "Animal" type parameter.
            AnimalHelpers.DisplayName(charlie);

            // Upcasting: charlieHorse is just a reference to charlie
            // with a more limited scope
            Animal charlieHorse = charlie;

            Console.WriteLine("Is charlieHorse charlie? " + (charlie == charlieHorse));

            // Downcasting:
            Horse sameCharlie = (Horse)charlieHorse;

            // Although charlieHorse was of type "Animal," we didn't lose any of the properties
            // that were in the original, "charlie" since charlieHorse was just a reference. 
            // However, if you tried to output the contents of charlieHourse.ManeColor, it wouldn't work!
            Console.WriteLine("sameCharlie mane is: " + sameCharlie.ManeColor);

            // Downcast doesn't work if your instance is based on a base class and it isn't
            // just upcasted to the base class. That is, because henry was created as an "Animal"
            // we can't downcast him to to a Dog subclass. Check the static function that this calls.
            Dog henryDog = DowncastFromAnimal(henry);


            // However, if we know that there's a possibility of this occuring, we shouldn't use 
            // catching exceptions for branching our code (for logic).
            // We can, however, use the "as" operator, which evaluates to a null if the downcast fails.
            Dog henryDogWithAs = henry as Dog;

            if(henryDogWithAs == null)
                Console.WriteLine("henryDogWithAs is null");

            // Or better yet we can check if we can even perform the downcasting with the is
            // operator:

            if(henry is Dog) 
                Console.WriteLine("Downcasting henry to Dog is possible");
            else
                Console.WriteLine("Downcasting henry to Dog is not possible ");
            
            // Notice that this will work because although charlieHorse is of the Animal type, it was
            // originally upcast from the Horse type and since upcasting still holds a refernce to the
            // original instance, it can easily be downcast again. 
            if(charlieHorse is Horse) 
                Console.WriteLine("charlieHorse can be downcast to Horse and his mane color is: " + ((Horse)charlieHorse).ManeColor);


        }
    }
}
