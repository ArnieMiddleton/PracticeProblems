using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
  class BitwiseAndOfNumbersRangeSolution
  {
    public int RangeBitwiseAnd(int left, int right)
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
