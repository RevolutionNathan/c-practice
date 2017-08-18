using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class TortiseRace
    {
        public int[] Race(int v1, int v2, int g)
        {
            int[] raceClock = new int[3];
            double lead = Convert.ToDouble(g);
            double vee1 = Convert.ToDouble(v1);
            double vee2 = Convert.ToDouble(v2);
            double v1FtPerSecond = vee1 / 3600;
            double v2FtPerSecond = vee2 / 3600;
            int raceTimer = 0;
            int minutes = 0;
            int hours = 0;
            
            while (lead > 0)
            {
                raceTimer++;
                lead -= v2FtPerSecond;
                lead += v1FtPerSecond;
                if (raceTimer % 60 == 0)
                {
                    minutes++; 
                }
                if (raceTimer % 3600 == 0)
                {
                    hours++;
                }
            }
            raceTimer -= (hours * 3600);
            raceTimer -= (minutes * 60);

            raceClock[0] = hours;
            raceClock[1] = minutes;
            raceClock[2] = raceTimer;

            return raceClock;
        }
    }
}
