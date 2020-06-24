using System;
using System.Collections.Generic;

namespace Codility
{
    class MissingInteger
    {
        public int solution(int[] A)
        {
            var hset = new HashSet<int>();
            int max = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    hset.Add(A[i]);
                    max = Math.Max(max, A[i]);
                }
            }

            for (int i = 1; i <= max + 1; i++)
            {
                if (!hset.Contains(i)) return i;
            }
            return 1;
        }
    }
}


//Write a function:

//class Solution { public int solution(int[] A); }

//that, given an array A of N integers, returns the smallest positive integer(greater than 0) that does not occur in A.

//For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

//Given A = [1, 2, 3], the function should return 4.

//Given A = [−1, −3], the function should return 1.

//Write an efficient algorithm for the following assumptions:

//N is an integer within the range[1..100, 000];
//each element of array A is an integer within the range[−1, 000, 000..1, 000, 000].