using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's model a car by using a Dictionary
            // Properties are Make, Model, Year, and Price
            Dictionary<string, string> ford = new Dictionary<string, string>()
            {
                {"Year", "1914"},
                {"Make", "Ford"},
                {"Model", "T"},
                {"Price", "300"}
            };

            Dictionary<string, string> tesla = new Dictionary<string, string>()
            {
                {"Year", "2017"},
                {"Make", "Tesla"},
                {"Model", "X"},
                {"Price", "80000.45"}
            };

            List<Dictionary<string, string>> garage = new List<Dictionary<string, string>>();

            garage.Add(ford);
            garage.Add(tesla);

            Console.WriteLine(tesla["Year"]);

            // Pain Points with using a Dictionary:
            // 1. Long code
            // 2. Redundant
            // 3. Hard to read, hard to understand
            // 4. Stringly typed, meaning a typo could end the program
            // 5. Doesn't force all cars to have the same properties
            // 6. I can't mix types!


            // Again with classes
            // I'll create two instances of my custom Car class

            // Here I'm creating a new Car, then aftwards, setting all it's properties
            Car ford2 = new Car();
            ford2.Year = 2017;
            ford2.Model = "Fiesta";
            ford2.Make = "Ford";
            ford2.Price = 32500.65;

            // Here I'm setting all the properties of the new Car at the same time as I create it
            // You can think of this being one single action while the previous example was multiple actions
            Car tesla2 = new Car()
            {
                Year = 2017,
                Model = "X",
                Price = 80000.42,
                Make = "Tesla"
            };

            // Here I'm creating a car, but only setting one of it's properties
            // The rest of the properties will have default values (zero for the number properties, and null for the string properties)
            Car toyota = new Car()
            {
                Model = "Corolla"
            };

            List<Car> garage2 = new List<Car>() { ford2, tesla2 };

            toyota.Drive();
        }
    }
}