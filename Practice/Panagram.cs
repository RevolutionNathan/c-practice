using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Practice
{
    public class PanagramPractice
    {

        //public char[] splitters = new char[] {',', ';', ':' };
        public List<char> alphabet = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public bool IsPangram(string str)
        {
            var noCase = str.ToLower();

            string[] test = Regex.Split(noCase, string.Empty);

            Dictionary<char, int> dictionary = new Dictionary<char, int>();

            foreach (char letter in alphabet)
            {
                int count = noCase.Where(x => x == letter).Count();

                if (count == 0) return false;

                dictionary.Add(letter, count);
            }
            foreach (var pair in dictionary)
            {
                if (pair.Value == 0 || pair.Value < 1)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

    }
}
