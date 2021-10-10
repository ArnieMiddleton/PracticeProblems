using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
  class BitwiseAndOfNumbersRangeSolution
  {
    public int RangeBitwiseAnd(int left, int right)
    {
      while (right > left)
      {
        right &= right - 1;
      }
      return right & left;
    }

    public int RangeBitwiseAndOld(int left, int right) // my original solution
    {
      uint temp = (uint)left;
      for (int i = left; i < right; i++)
      {
        temp = temp & (uint)i;
        if (temp == (uint)0)
          return 0;
      }
      temp = temp & (uint)right;

      return (int)temp;
    }
  }
}
