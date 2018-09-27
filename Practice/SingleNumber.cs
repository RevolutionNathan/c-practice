using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class SingleNumber
    {
        public int Solution(int[] nums)
        {
            int difference = nums.GroupBy(x => x).Where(y => y.Count() % 2 != 0 || y.Count() == 1).First().First();

            return difference;
            
        }

    }
}

