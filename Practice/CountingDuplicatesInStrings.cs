using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice
{
    class CountingDuplicatesInStrings
    {
        public int DuplicateCount(string str)
        {
            char [] stringArray = str.ToCharArray();

            int numberDupilcated = stringArray.GroupBy(x => x).Where(y => y.Count() > 1).Count();

            return numberDupilcated;
        }

    }
}
