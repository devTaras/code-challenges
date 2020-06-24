using System;

class Solution
{
    public int solution(int[] A)
    {
        int max1 = -1000, max2 = -1000, max3 = -1000;
        int min1 = 0, min2 = 0;
        foreach (int e in A)
        {
            if (e > max1) { max3 = max2; max2 = max1; max1 = e; }
            else if (e > max2) { max3 = max2; max2 = e; }
            else if (e > max3) { max3 = e; }
            if (e < min1) { min2 = min1; min1 = e; }
            else if (e < min2) { min2 = e; }
        }
        if (min2 * min1 * max1 > max2 * max1 * max3)
            return max1 * min1 * min2;
        return max1 * max2 * max3;
    }
}

//A non-empty array A consisting of N integers is given.The product of triplet(P, Q, R) equates to A[P] * A[Q] * A[R] (0 ≤ P<Q<R<N).


//For example, array A such that:


//A[0] = -3

//A[1] = 1

//A[2] = 2

//A[3] = -2

//A[4] = 5

//A[5] = 6
//contains the following example triplets:

//(0, 1, 2), product is −3 * 1 * 2 = −6
//(1, 2, 4), product is 1 * 2 * 5 = 10
//(2, 4, 5), product is 2 * 5 * 6 = 60
//Your goal is to find the maximal product of any triplet.

//Write a function:

//class Solution { public int solution(int[] A); }

//that, given a non-empty array A, returns the value of the maximal product of any triplet.

//For example, given array A such that:

//  A[0] = -3
//  A[1] = 1
//  A[2] = 2
//  A[3] = -2
//  A[4] = 5
//  A[5] = 6
//the function should return 60, as the product of triplet (2, 4, 5) is maximal.

//Write an efficient algorithm for the following assumptions:

//N is an integer within the range[3..100, 000];
//each element of array A is an integer within the range[−1, 000..1, 000].