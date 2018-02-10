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


        }
    }
}
