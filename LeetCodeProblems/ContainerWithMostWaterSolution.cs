using System;

namespace LeetCodeProblems
{
  class ContainerWithMostWaterSolution
  {
    /*
    You are given an integer array height of length n.
    There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and(i, height[i]).

    Find two lines that together with the x-axis form a container, such that the container contains the most water.

    Return the maximum amount of water a container can store.

    Notice that you may not slant the container.


    Example 1:

    Input: height = [1, 8, 6, 2, 5, 4, 8, 3, 7]
    Output: 49
    Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. 
    In this case, the max area of water (blue section) the container can contain is 49.


    Example 2:

    Input: height = [1,1]
    Output: 1
 

    Constraints:

    n == height.length
    2 <= n <= 105
    0 <= height[i] <= 104
    */

    /*
    public int MaxArea(int[] height) // Slow version
    {
      int maxArea = 0;
      for (int i = 0; i < height.Length; i++)
      {
        for (int j = i; j < height.Length; j++)
        {
          int area = Math.Min(height[i], height[j]) * (j - i);
          if (area > maxArea)
            maxArea = area;
        }
      }
      return maxArea;
    }
    */

    /*
    public int MaxArea(int[] height)
    {
      int i = 0;
      int j = height.Length - 1;

      int maxArea = Math.Min(height[i], height[j]) * (j - i);

      while (i < j)
      {
        bool checkAgain = false;
        if (Math.Min(height[i + 1], height[j]) * (j - (i + 1)) > maxArea)
        {
          i++;
          maxArea = Math.Min(height[i], height[j]) * (j - i);
          checkAgain = true;
        }
        if (Math.Min(height[i], height[j - 1]) * ((j - 1) - i) > maxArea)
        {
          j--;
          maxArea = Math.Min(height[i], height[j]) * (j - i);
          checkAgain = true;
        }

        if (height[i + 1] > height[i] && !checkAgain)
        {
          i++;
          checkAgain = true;
        }
        if (height[j - 1] > height[j] && !checkAgain)
        {
          j--;
          checkAgain = true;
        }
        if (!checkAgain)
          break;
      }

      return maxArea;
    }*/

    public int MaxArea(int[] height)
    {
      int i = 0;
      int j = height.Length - 1;
      int maxArea = 0;
      while (i < j)
      {
        maxArea = Math.Max(maxArea, (j - i) * Math.Min(height[i], height[j]));
        if (height[i] < height[j])
          i++;
        else
          j--;
      }

      return maxArea;
    }
  }
}