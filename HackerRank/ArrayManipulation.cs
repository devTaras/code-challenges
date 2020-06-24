namespace HackerRank
{
    using System;
    using System.IO;

    class Solution
    {

        // Complete the arrayManipulation function below.
        static long arrayManipulation(int n, int[][] queries)
        {
            long[] arr = new long[n + 1];
            long max = 0, x = 0;
            for (int i = 0; i < queries.Length; i++)
            {
                int start = queries[i][0];
                int finish = queries[i][1];
                int summand = queries[i][2];

                arr[start] += summand;
                if ((finish + 1) <= n)
                    arr[finish + 1] -= summand;

            }
            for (int i = 1; i <= n; i++)
            {
                x += arr[i];
                max = Math.Max(max, x);
            }

            return max;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[][] queries = new int[m][];

            for (int i = 0; i < m; i++)
            {
                queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
            }

            long result = arrayManipulation(n, queries);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}


//Starting with a 1-indexed array of zeros and a list of operations, for each operation add a value to each of the array element between two given indices, inclusive.Once all operations have been performed, return the maximum value in your array.

//For example, the length of your array of zeros.Your list of queries is as follows:


//   a b k
//    1 5 3
//    4 8 7
//    6 9 1
//Add the values of  between the indices and  inclusive:


//index->	 1 2 3  4  5 6 7 8 9 10

//   [0,0,0, 0, 0,0,0,0,0, 0]
//    [3,3,3, 3, 3,0,0,0,0, 0]
//    [3,3,3,10,10,7,7,7,0, 0]
//    [3,3,3,10,10,8,8,8,1, 0]
//The largest value is  after all operations are performed.

//Function Description


//Complete the function arrayManipulation in the editor below.It must return an integer, the maximum value in the resulting array.

//arrayManipulation has the following parameters:


//n - the number of elements in your array
//queries - a two dimensional array of queries where each queries[i] contains three integers, a, b, and k.
//Input Format


//The first line contains two space-separated integers  and , the size of the array and the number of operations.
//Each of the next  lines contains three space-separated integers, a, b and k, the left index, right index and summand.


//Constraints

//Output Format

//Return the integer maximum value in the finished array.

//Sample Input

//5 3
//1 2 100
//2 5 100
//3 4 100
//Sample Output

//200
//Explanation

//After the first update list will be 100 100 0 0 0.
//After the second update list will be 100 200 100 100 100.
//After the third update list will be 100 200 200 200 100.
//The required answer will be 200.