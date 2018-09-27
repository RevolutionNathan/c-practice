using System;
namespace Practice
{
    public class CoveringPrefixArrays
    {
        public CoveringPrefixArrays()
        {
        }

        int[] A = new int[] { 2, 2, 1, 0, 1 };
        int indexOfSmallestIntegerInArray;
        int smallestIntegerInArray;

		public int solution(int[] A)
		{
            indexOfSmallestIntegerInArray = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] <= smallestIntegerInArray)
                {
					indexOfSmallestIntegerInArray = i;
                }
            }
            return indexOfSmallestIntegerInArray;
		}
    }
}
