using System;
using System.Linq;

namespace Practice
{
    public class BinaryGap
    {
        public int solution(int N)
        {
            string S = Convert.ToString(N, 2);

            var splitBinaryString = S.Split('1');

            int longestGap = splitBinaryString.OrderByDescending(s => s.Length).First().Length;

            return longestGap;
        }

    }
}
