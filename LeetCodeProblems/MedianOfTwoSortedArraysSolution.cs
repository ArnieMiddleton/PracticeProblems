using System;
using System.Text;

namespace LeetCodeProblems
{
  class MedianOfTwoSortedArraysSolution
  {

    public string PrintArray(int[] arr)
    {
      StringBuilder sb = new StringBuilder("[");
      for (int i = 0; i < arr.Length - 1; i++)
      {
        sb.Append(arr[i] + ", ");
      }
      if (arr.Length > 0)
      {
        sb.Append(arr[arr.Length - 1] + "]");
      }
      return sb.ToString();
    }

    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
      int idx1 = 0;
      int idx2 = 0;
      int idxMerged = 0;
      int[] mergedArray = new int[nums1.Length + nums2.Length];
      int mergedSize = mergedArray.Length;

      while (idx1 < nums1.Length && idx2 < nums2.Length)
      {
        if (nums1[idx1] < nums2[idx2])
        {
          mergedArray[idxMerged] = nums1[idx1];
          idxMerged++;
          idx1++;
        }
        else
        {
          mergedArray[idxMerged] = nums2[idx2];
          idxMerged++;
          idx2++;
        }
      }

      while (idx1 < nums1.Length)
      {
        mergedArray[idxMerged] = nums1[idx1];
        idxMerged++;
        idx1++;
      }

      while (idx2 < nums2.Length)
      {
        mergedArray[idxMerged] = nums2[idx2];
        idxMerged++;
        idx2++;
      }

      if (idxMerged % 2 == 0)
      {
        return (double)(mergedArray[(mergedSize - 1) / 2] + mergedArray[((mergedSize - 1) / 2) + 1]) / 2;
      }
      else
      {
        return (double)mergedArray[(mergedSize / 2)];
      }
    }
  }
}
