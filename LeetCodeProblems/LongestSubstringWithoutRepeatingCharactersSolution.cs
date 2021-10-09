using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
  class LongestSubstringWithoutRepeatingCharactersSolution
  {
    public int LengthOfLongestSubstring(string s)
    {
      int max = 0;
      int startIndex = 0;
      bool foundRepeat = false;

      HashSet<char> chars = new HashSet<char>();
      for (int i = 0; i < s.Length; i++)
      {
        if (chars.Contains(s[i]))
        {
          max = Math.Max(max, i - startIndex);
          chars.Clear();
          i = startIndex;
          startIndex++;
          foundRepeat = true;
        }
        else
          chars.Add(s[i]);
      }
      max = Math.Max(max, chars.Count);

      return max;
    }
  }
}
