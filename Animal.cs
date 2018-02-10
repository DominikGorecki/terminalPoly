namespace terminalPoly {
    public class Animal {
        public Animal() {
            Population++;
        }
        public string Name;
        public static int Population = 0;
    }

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
