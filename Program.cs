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
        }
    }
}
