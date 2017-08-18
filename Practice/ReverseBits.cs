using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice
{
    class ReverseBits
    {

        public uint IntReversedByBits(int n)
        {
            uint r = 0;
            string bits;
            string[] splitBitsString = new string[32];
            bits = Convert.ToString(n, 2).PadLeft(32, '0');
            splitBitsString = Regex.Split(bits, "");
            Array.Reverse(splitBitsString);

            StringBuilder stringInt = new StringBuilder();

            foreach(string value in splitBitsString)
            {
                stringInt.Append(value);
            }

            r = Convert.ToUInt32(stringInt.ToString(), 2);

            return r;
        }
       
    }
}
