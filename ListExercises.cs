using System.Collections.Generic;
using System.Linq;

namespace AutomationStudyGit
{
    public class ListExercises
    {
        public List<string> CapitalizeListElements(List<string> list)
        {
            List<string> list1 = new List<string>(list);

            for (int i = 0; i < list.Count; i++)
            {
                list1[i] = list1[i].ToLower();
                list1[i] = CapitalizeString(list1[i]);
            }
            return list1;
        }

        private string CapitalizeString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return string.Empty;
            }
            return char.ToUpper(str[0]) + str.Substring(1);
        }

        public List<string> ReturnElementsStartingWithVowels(List<string> list)
        {
            List<string> list1 = new List<string>(list);
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < list1.Count; i++)
            {
                char firstChar = list1[i].ToLower().ToCharArray()[0];
                if (!vowels.Contains(firstChar))
                {
                    list1.RemoveAt(i);
                    i--;
                }
            }
            return list1;
        }

        public List<string> ReturnElementsStartingWithConsonant(List<string> list)
        {
            List<string> list1 = new List<string>(list);
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < list1.Count; i++)
            {
                char firstChar = list1[i].ToLower().ToCharArray()[0];
                if (vowels.Contains(firstChar))
                {
                    list1.RemoveAt(i);
                    i--;
                }
            }
            return list1;
        }
    }
}
