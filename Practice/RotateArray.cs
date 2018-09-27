using System;
namespace Practice
{
    public class RotateArray
    {
        public RotateArray()
        {
        }

        public int[] solution(int[] A, int K)
        {
            int indexerGet;
            int[] rotatedArray = new int[A.Length];
            indexerGet = K - 1;
            if (A.Length > 0 && K != 0)
            {
                for (int indexerFill = 0; indexerFill < A.Length; indexerFill++)
                {
                    if (indexerGet < A.Length)
                    {
                        rotatedArray[indexerFill] = A[indexerGet];
						indexerGet++;

                    }
                    else if (indexerGet >= A.Length)
                    {
                        indexerGet = 0;
                        rotatedArray[indexerFill] = A[indexerGet];
                        indexerGet++;

                    }
                }
            }
            return rotatedArray;
        }
    }

}
