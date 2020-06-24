using System;
using System.Collections.Generic;
using System.Text;

namespace Codility
{
    class SplitSubArray
    {
        public static int SplitArrayWithNumber(int[] A, int x)
        {
            int lastXpos =-1, countX = 0; ;
            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] == x)
                {
                    lastXpos = i;
                    countX++;
                }
            }
            return 0;
        }
    }
}
