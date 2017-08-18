using System;
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
            int v1 = 720;
            int v2 = 850;
            int g = 70;

            TortiseRace TR = new TortiseRace();
            TR.Race(v1, v2, g);

            Console.ReadKey();

        }
    }
}
