using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class RouteCircle
    {
        private IDictionary<char, int[]> dirnMap = new Dictionary<char, int[]>();
        public RouteCircle()
        {
            dirnMap.Add('L', new int[2] { -1, 0 });
            dirnMap.Add('U', new int[2] { 0, 1 });
            dirnMap.Add('R', new int[2] { 1, 0 });
            dirnMap.Add('D', new int[2] { 0, -1 });

        }
        public bool JudgeCircle(string moves)
        {
            if (string.IsNullOrEmpty(moves))
            {
                return true;
            }
            int xPos = 0, yPos = 0;
            foreach (char move in moves)
            {
                int[] m = dirnMap[move];
                xPos += m[0];
                yPos += m[1];
            }

            return xPos == 0 && yPos == 0;
        }
    }
}
