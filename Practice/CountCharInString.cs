using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delete
{
    class CountCharInString
    {

        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> retval = new Dictionary<char, int>();
            if (string.IsNullOrEmpty(str)) return retval;

            retval = str.GroupBy(x => x).ToDictionary(y => y.Key, z => z.Count());

            return retval;
        }
    }
}
