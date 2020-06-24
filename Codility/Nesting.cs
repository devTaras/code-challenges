using System.Collections.Generic;

namespace Codility
{
    class Nesting
    {
        public int solution(string S)
        {
            if (S.Length == 0) return 1;
            if (S[0] == ')' || S.Length % 2 != 0)
                return 0;
            var stack = new Stack<char>();
            stack.Push(S[0]);
            for (int i = 1; i < S.Length; i++)
            {
                if (stack.Count > 0)
                {
                    var temp = stack.Peek();
                    if (S[i] == temp) stack.Push(S[i]);
                    else stack.Pop();
                }
                else
                {
                    if (S[i] == ')') return 0;
                    stack.Push(S[i]);
                }
            }

            return stack.Count == 0 ? 1 : 0;
        }
    }
}


//A string S consisting of N characters is called properly nested if:

//S is empty;
//S has the form "(U)" where U is a properly nested string;
//S has the form "VW" where V and W are properly nested strings.
//For example, string "(()(())())" is properly nested but string "())" isn't.

//Write a function:

//class Solution { public int solution(string S); }

//that, given a string S consisting of N characters, returns 1 if string S is properly nested and 0 otherwise.

//For example, given S = "(()(())())", the function should return 1 and given S = "())", the function should return 0, as explained above.

//Write an efficient algorithm for the following assumptions:

//N is an integer within the range[0..1, 000, 000];
//string S consists only of the characters "(" and/or ")".