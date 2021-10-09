using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
  class FindAllDuplicatesInAnArraySolution
  {
    /*  Given an integer array nums of length n where all the integers of nums are in the range [1, n] and each integer
     *  appears once or twice, return an array of all the integers that appears twice.
     *  You must write an algorithm that runs in O(n) time and uses only constant extra space.

        Example 1:
        Input: nums = [4,3,2,7,8,2,3,1]
        Output: [2,3]

        Example 2:
        Input: nums = [1,1,2]
        Output: [1]

        Example 3:
        Input: nums = [1]
        Output: []
     */

    public string PrintList(IList<int> list)
    {
      StringBuilder sb = new StringBuilder("[");
      foreach (int i in list)
      {
        sb.Append(i + ", ");
      }
      sb.Append("]");
      return sb.ToString();
    }


    public IList<int> FindDuplicates(int[] nums)
    {
      bool[] counts = new bool[nums.Length];
      List<int> output = new List<int>();

      foreach (int i in nums)
      {
        if (counts[i - 1])
        {
          output.Add(i);
        }
        else if (!counts[i - 1])
        {
          counts[i - 1] = true;
        }
      }

      return output;
    }
  }
}
