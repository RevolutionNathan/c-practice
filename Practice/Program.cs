﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Test";

            FirstInstanceOfNonRepeatingLetter fin = new FirstInstanceOfNonRepeatingLetter();

            string result = fin.FirstNonRepeatingLetter(test);
                                              
            Console.Write(result);
            Console.ReadKey();

        }
    }
}
