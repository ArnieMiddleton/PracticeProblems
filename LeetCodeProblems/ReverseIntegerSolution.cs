using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
  class ReverseIntegerSolution
  {
    /*
     * Given a signed 32-bit integer x, return x with its digits reversed. 
     * If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

      Assume the environment does not allow you to store 64-bit integers (signed or unsigned).


      Example 1:

      Input: x = 123
      Output: 321


      Example 2:

      Input: x = -123
      Output: -321


      Example 3:

      Input: x = 120
      Output: 21


      Example 4:

      Input: x = 0
      Output: 0
    */
    public int Reverse(int x)
    {
      bool isNeg = x < 0;
      int absX = x;
      try
      {
        absX = Math.Abs(x);
      }
      catch
      {
        return 0;
      }
      string absXString = absX.ToString();
      string absXReversedString;
      StringBuilder sb = new StringBuilder();

      for (int i = absXString.Length - 1; i >= 0; i--)
        sb.Append(absXString[i]);

      absXReversedString = sb.ToString();

      if (Int32.TryParse(absXReversedString, out int output))
        return output * (isNeg ? -1 : 1);

      return 0;
    }
  }
}
