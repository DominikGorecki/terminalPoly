using System;

namespace terminalPoly
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal henry = new Animal(){
                Name= "Henry"
            };

            Horse charlie = new Horse() {
                Name = "Charlie",
                ManeColor = "Brown"
            };

            Console.WriteLine("Population: " + Animal.Population);
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
            Console.WriteLine(sameCharlie.ManeColor);

        }
    }
}
