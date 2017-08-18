using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class MissingNumber
    {
        public int MissingNumberProblem(int[] nums)
        {
            Array.Sort(nums);

            int MissingNumber;
            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] != i)
                {
                    MissingNumber = i;

                    return MissingNumber;
                }
            }
            return nums.Count();

        }
    }
}

