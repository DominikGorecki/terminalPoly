using System;
namespace terminalPoly {

    public static class AnimalHelpers {
        /// <summary>
        /// This static class illustrates polymorphism when
        /// an instance of an object that inherits from the
        /// animal class can be passed into this method
        /// </summary>
        public static void DisplayName(Animal animal) {
            Console.WriteLine("Animal's name is: " + animal.Name);
        }
    }

    public class Animal {
        public Animal() {
            Population++;
        }
        public string Name;
        public static int Population = 0;
    }

    // example of inheritance. Horse also has he public property
    // "Name" that is inherited from "Animal."
    public class Horse : Animal {
        public Horse() {
            HorsePopulation++;
        }
        public string ManeColor;
        public static int HorsePopulation = 0;
    }

    public class Dog : Animal {
        public string Leash;
    }
}
