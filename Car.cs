using System;

namespace ClassIntro
{
    public class Car
    {
        // This is called a field, and not a property
        // By convention these are private, and internal to this class.
        // These do not explicitly specify getters and setters
        private int _miles = 0;

        public int Year { get; set; }

        public string Model { get; set; }

        public string Make { get; set; }

        public double Price { get; set; }


        // These are my constructors. Constructors are what gets called when
        // anyone calls:  new Car()
        // I can overload it, just like any other method
        // Here I have one constructor that takes an int, and another that takes no parameters
        public Car(int startingMiles)
        {
            _miles = startingMiles;
        }

        public Car()
        {

        }


        // Method Overloading
        // I can create multiple methods called Drive as long as their signatures are different
        // The first takes no params, the second takes an int, and the third takes a string.
        // When you eventually call Drive, the compiler will know which method to call based off the params you pass it
        public void Drive()
        {
            if (Make == null)
            {
                Console.WriteLine($"Sorry dawg, no make");
            }
            else
            {
                Console.WriteLine($"{Make}: I'm drivin' here!!!");
            }

        }

        public void Drive(int miles)
        {
            _miles += miles;
            Console.WriteLine($"{Make} is driving for {miles} miles");
            Console.WriteLine($"Your odometer is now at {_miles}");
        }

        public void Drive(string hornSound)
        {
            Console.WriteLine($"The {Make} goes {hornSound}");
        }


    }
}