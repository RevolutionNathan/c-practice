using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    public class FirstInstanceOfNonRepeatingLetter
    {
        public FirstInstanceOfNonRepeatingLetter()
        {
        }

        public string FirstNonRepeatingLetter(string s)
        {

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            List<string> list = new List<string>();

            char[] charArray = s.ToCharArray();
            foreach (var character in charArray)
            {
                list.Add(character.ToString());
            }

            foreach (string letter in list)
            {
                if (dictionary.ContainsKey(letter.ToLowerInvariant()))
                {
                    dictionary[letter] += 1;
                }
                else
                {
                    dictionary.Add(letter, 1);
                }
            }

            var distinct = dictionary.Where(x => x.Value == 1);
            string finalLetter = distinct.FirstOrDefault().Key.ToString();
            return finalLetter.Equals("\0") ? String.Empty : finalLetter;

        }
    }
}
