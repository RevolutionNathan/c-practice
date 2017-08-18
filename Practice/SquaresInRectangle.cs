using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class SquaresInRectangle
    {
        public List<int> sqInRect(int lng, int wdth)
        {
            List<int> squareSizes = new List<int>();
            if (lng == wdth)
            {
                return null;
            }
            else
            {
                while (lng > 0 && wdth > 0)
                {
                    if (wdth > lng)
                    {
                        squareSizes.Add(lng);
                        wdth -= lng;
                    }
                    else 
                    {
                        squareSizes.Add(wdth);
                        lng -= wdth;
                    }
                }
                return squareSizes;
            }
           
        }
    }
}



//List<int> squareSizes = new List<int>();
//int squareSide = 1;
//int area = lng * wdth;

//            else
//            {
//                while (area > 0)
//                {
//                    int tempArea = squareSide * squareSide;

//                    if (tempArea > area)
//                    {
//                        squareSizes.Add(squareSide - 1);
//                        area = area - (squareSide - 1) * (squareSide - 1);
//                        squareSide = 0;
//                    }

//                    squareSide++;

//                }
//                return squareSizes;
//            }