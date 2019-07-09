using System;

namespace ClassIntro
{
    public class Car
    {
        public int Year { get; set; }

        public string Model { get; set; }

        public string Make { get; set; }

        public double Price { get; set; }


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
            Console.WriteLine($"{Make} is driving for {miles} miles");
        }

        public void Drive(string hornSound)
        {
            Console.WriteLine($"The {Make} goes {hornSound}");
        }


    }
}