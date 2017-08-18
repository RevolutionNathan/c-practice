using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practice
{
    class DNA
    {
        //public string firstString = "ATTGC";
        public string secondString;

        //char delimiterChar = "";


        public string[] splitStringOne = new string[10];
        public string[] partnerArray = new string[10];
            
        public string MakeComplement(string dna)
        {
            splitStringOne = Regex.Split(dna, "");

            for (int i = 0; i < splitStringOne.Count(); i++)
            {
                if (splitStringOne[i] == "A")
                {
                    partnerArray[i] = "T";
                }
                if (splitStringOne[i] == "T")
                {
                    partnerArray[i] = "A";
                }
                if (splitStringOne[i] == "C")
                {
                    partnerArray[i] = "G";
                }
                if (splitStringOne[i] == "G")
                {
                    partnerArray[i] = "C";
                }
            }
            secondString = string.Concat(partnerArray);

            return secondString;
        }


    }
}
