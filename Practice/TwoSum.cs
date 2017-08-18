using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class TwoSums
    {
        public int[] TwoSum(int[] nums, int target)
        {

            if (nums.Length > 0)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = 0; j < nums.Length; j++)
                    {
                        if (nums[j] == nums[i] - target)
                        {
                            return new int[] { i, j };
                        }
                    }
                }
            }
            throw new Exception("No two sum solution");
        }
    }
}
