namespace Codility
{
    class NumberOfDiscIntersections
    {
        public int solution(int[] A)
        {
            int result = 0;
            int[] dps = new int[A.Length];
            int[] dpe = new int[A.Length];
            int t = A.Length - 1;
            for (int i = 0; i < A.Length; i++)
            {
                int s = i > A[i] ? i - A[i] : 0;
                int e = t - i > A[i] ? i + A[i] : t;
                dps[s]++;
                dpe[e]++;
            }

            t = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (dps[i] > 0)
                {
                    result += t * dps[i];
                    result += dps[i] * (dps[i] - 1) / 2;
                    if (10000000 < result) return -1;
                    t += dps[i];
                }
                t -= dpe[i];
            }

            return result;
        }
    }
}

// This is easy.Intiially we calculate all start and end points of discs.
// After go by all line and check count of discs inside current point.
// If in current point started some discs and intersection count increased by: 
// already active distsc multiplied by count of started in current point (result += t* dps[i]) 
// and count of intersections of started(result += dps[i] * (dps[i] - 1) / 2) 
// eg. if started 5 discs in one of point it will increased by(1+2+3+4+5 intersections, 
// or 5*(5-1) / 2[sum formula]). – Толя Oct 23 '13 at 6:34

// What a brilliant solution! This should be the correct(more correct :)) answer. 
// Just to add a bit more explanation to what Tolia has.Basically, 
// we are keeping track of the current "active" disks at each location. 
// This is the value of t. Whenever a new disk starts at location i, 
// it intersects with all existing disks at that location.That's why we have result += t * dps[i]. 
// We also need to add the number of intersections for all the disks that just started at location i, i.e., 
// the number of intersections within themselves excluding whatever already 
// existed(result += dps[i] * (dps[i] - 1) / 2) – Abdul Oct 20 '14 at 0:01


//public int solution(int[] A)
//{
//    int pairs = 0;
//    for (int i = 0; i < A.Length; i++)
//    {
//        long a = i - (long)A[i];
//        long b = i + (long)A[i];
//        for (int j = i + 1; j < A.Length; j++)
//        {
//            long c = j - (long)A[j];
//            long d = j + (long)A[j];
//            if (!(d < a || b < c))
//                pairs++;
//            if (pairs > 10000000) return -1;
//        }

//    }
//    return pairs;
//}

//We draw N discs on a plane.The discs are numbered from 0 to N − 1. An array A of N non-negative integers, specifying the radiuses of the discs, is given.The J-th disc is drawn with its center at(J, 0) and radius A[J].

//We say that the J-th disc and K-th disc intersect if J ≠ K and the J-th and K-th discs have at least one common point(assuming that the discs contain their borders).

//The figure below shows discs drawn for N = 6 and A as follows:

//  A[0] = 1
//  A[1] = 5
//  A[2] = 2
//  A[3] = 1
//  A[4] = 4
//  A[5] = 0


//There are eleven(unordered) pairs of discs that intersect, namely:

//discs 1 and 4 intersect, and both intersect with all the other discs;
//disc 2 also intersects with discs 0 and 3.
//Write a function:

//class Solution { public int solution(int[] A); }

//that, given an array A describing N discs as explained above, returns the number of(unordered) pairs of intersecting discs.The function should return −1 if the number of intersecting pairs exceeds 10,000,000.


//Given array A shown above, the function should return 11, as explained above.


//Write an efficient algorithm for the following assumptions:


//N is an integer within the range[0..100, 000];
//each element of array A is an integer within the range[0..2, 147, 483, 647].