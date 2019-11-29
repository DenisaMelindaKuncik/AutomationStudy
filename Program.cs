using System;
using System.Collections.Generic;

namespace AutomationStudyGit
{
    class Program
    {
        public static void Main(string[] args)
        {
            ListExercises ls = new ListExercises();

            List<string> names = new List<string>() { "anA", "elena", "MARIA", "cRisTiAn", "aDriANA" };
            List<string> capitalizedNames = ls.CapitalizeListElements(names);

            Console.WriteLine("List with names capitalized:");
            foreach (var elem in capitalizedNames)
            {
                Console.WriteLine(elem);
            }

            List<string> namesStartingWithVowels = ls.ReturnElementsStartingWithVowels(names);

            Console.WriteLine("List with names starting with vowels:");
            foreach (var elem in namesStartingWithVowels)
            {
                Console.WriteLine(elem);
            }


            List<string> namesStartingWithConsonant = ls.ReturnElementsStartingWithConsonant(names);

            Console.WriteLine("List with names starting with consonant:");
            foreach (var elem in namesStartingWithConsonant)
            {
                Console.WriteLine(elem);
            }

            Car myCar = new Car("Audi", "A4", "CJ-13-AAA", "2015", 5000);
            Console.WriteLine(ExtensionMethods.ToString(myCar));

            Vehicle vehicleModel = SetupVehicleModel();
            Car myCar1 = new Car(vehicleModel);
            Console.WriteLine(ExtensionMethods.ToString(myCar1));
        }

        private static Vehicle SetupVehicleModel()
        {
            Vehicle model = new Vehicle
            {
                Make = "Ford",
                Model = "Focus",
                Registration = "CJ-99-AAA",
                Year = "2018",
                CurrentValue = 10000,
            };
            return model;
        }
    }
}
