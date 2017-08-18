using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice
{
    class DifferenceBtwStrings
    {
        public char FindTheDifference(string s, string t)
        {
            
            char[] one = s.ToCharArray();
            char[] two = t.ToCharArray();

            char difference;
            char none = 'z';
            foreach (var letter in one)
            {
                for (int i = 0; i < two.Length; i++)
                {
                    if (letter != two[i])
                    {
                        difference = two[i];
                        return difference;

                    }
                }
            }
                
            return none;

        }

        public char FindTheDifferenceLinq(string s, string t)
        {
            
            char[] charArray = (s + t).ToCharArray();
           
            char difference = charArray.GroupBy(x => x).Where(y => y.Count() % 2 != 0 || y.Count() == 1).First().First();
            return difference;

        }
    }
}

