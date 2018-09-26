using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delete
{
    class FirstNonRepChar
    {

        //string test = "Test";
        public string FirstNonRepeatString(string s)
        {
            var distinct = s.GroupBy(x => x.ToString(), x => x, StringComparer.OrdinalIgnoreCase)
                .Where(y => y.Count() == 1)
                .Select(z => z.Key);
            if (distinct.Count() < 1) return string.Empty;

            if (distinct.ToString().Equals("/0"))
            {
                return string.Empty;
            }
            else
            {
                return distinct.FirstOrDefault().ToString();

            }
        }


    }
}
