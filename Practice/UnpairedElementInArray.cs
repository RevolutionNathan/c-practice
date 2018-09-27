using System;
using System.Linq;
namespace Practice
{
    public class UnpairedElementInArray
    {
        public UnpairedElementInArray()
        {
        }

		public int solution(int[] A)
		{
            // int unpairedElement = 
            return A.GroupBy(x => x).Where(y => y.Count() == 1).First().First();
		}
    }
}
