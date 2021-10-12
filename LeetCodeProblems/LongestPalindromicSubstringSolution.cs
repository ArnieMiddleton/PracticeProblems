using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
  class LongestPalindromicSubstringSolution
  {


    /// <summary>
    /// Given a string s, return the longest palindromic substring in s.
    /// 
    /// 
    ///Example 1:
    ///
    ///Input: s = "babad"
    ///Output: "bab"
    ///Note: "aba" is also a valid answer.
    ///
    ///Example 2:
    ///Input: s = "cbbd"
    ///Output: "bb"
    ///
    ///Example 3:
    ///
    ///Input: s = "a"
    ///Output: "a"
    ///
    ///Example 4:
    ///
    ///Input: s = "ac"
    ///Output: "a"
    /// </summary>
    /// <param name="s">Input string</param>
    /// <returns>Logest Palindromic Substring</returns>
    public string LongestPalindrome(string s)
    {
      string longPal = s[0].ToString();
      
      for (int i = 1; i < s.Length; i++)
      {
        if (s[i] == s[i - 1])
        {
          int j = i;
          int k = i - 1;
          while (j < s.Length && k >= 0)
          {
            if (s[j] == s[k])
            {
              string pal = s[k..(j+1)];
              if (pal.Length > longPal.Length)
                longPal = pal;
            }
            else
              break;
            j++;
            k--;
          }
        }
      }
      for (int i = 2; i < s.Length; i++)
      {
        if (s[i] == s[i - 2])
        {
          int j = i;
          int k = i - 2;
          while (j < s.Length && k >= 0)
          {
            if (s[j] == s[k])
            {
              string pal = s[k..(j + 1)];
              if (pal.Length > longPal.Length)
                longPal = pal;
            }
            else
              break;
            j++;
            k--;
          }
        }
      }

      return longPal;
    }
  }
}
