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
        }
    }
}
