﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class LongestSubstring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            int n = s.Length, ans = 0;
            int[] index = new int[128]; // current index of character

            for (int j = 0, i = 0; j < n; j++)
            {
                i = Math.Max(index[s[j]], i);
                ans = Math.Max(ans, j - i + 1);
                index[s[j]] = j + 1;
            }
            return ans;
        }
    }
}


//Given a string, find the length of the longest substring without repeating characters.

//Example 1:

//Input: "abcabcbb"
//Output: 3 
//Explanation: The answer is "abc", with the length of 3. 
//Example 2:

//Input: "bbbbb"
//Output: 1
//Explanation: The answer is "b", with the length of 1.
//Example 3:

//Input: "pwwkew"
//Output: 3
//Explanation: The answer is "wke", with the length of 3. 
//             Note that the answer must be a substring, "pwke" is a subsequence and not a substring.