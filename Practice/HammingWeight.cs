using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice
{
    class HammingWeight
    {
        public int GetHammingWeight (uint n)
        {
            int HammingWeight = 0;
            string bits;
            string[] splitBitsString = new string[32];
            bits = Convert.ToString(n, 2).PadLeft(32, '0');
            splitBitsString = Regex.Split(bits, "");
            foreach (var bit in splitBitsString)
            {
                if (bit == "1")
                {
                    HammingWeight++;
                } 
            }

            return HammingWeight;
        }

        public string GetIntBinaryString(uint n)
        {
            char[] b = new char[32];
            int pos = 31;
            int i = 0;

            while (i < 32)
            {
                if ((n & (1 << i)) != 0)
                {
                    b[pos] = '1';
                }
                else
                {
                    b[pos] = '0';
                }
                pos--;
                i++;
            }
            return new string(b);
        }

    }
    
}
