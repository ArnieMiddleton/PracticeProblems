﻿using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
  class MainClass
  {

    private static void PrintArray<T>(IList<T> arr)
    {
      Console.Write("[ ");
      for (int i = 0; i < arr.Count; i++)
      {
        Console.Write(arr[i].ToString() + " ");
      }
      Console.WriteLine("]");
    }

    static void Main(string[] args)
    {
      #region AddTwoNumbers
      /*
      AddTwoNumbersSolution atns = new AddTwoNumbersSolution();
      int num1 = 342;
      int num2 = 465;
      ListNode l1 = atns.GetListNodeFromList(atns.DigitsFromInt(num1));
      ListNode l2 = atns.GetListNodeFromList(atns.DigitsFromInt(num2));

      ListNode output = atns.AddTwoNumbers(l1, l2);

      Console.WriteLine(atns.PrintListNode(output));
      */
      #endregion

      #region FindMedianOfTwoSortedArrays
      /*
      MedianOfTwoSortedArraysSolution motsas = new MedianOfTwoSortedArraysSolution();
      int[] a1 = new int[] { 1, 3 };
      int[] a2 = new int[] { 2 };


      Console.WriteLine(motsas.FindMedianSortedArrays(a1, a2));
      */
      #endregion

      #region FindAllDuplicatesInAnArray
      /*
      FindAllDuplicatesInAnArraySolution fadiaas = new FindAllDuplicatesInAnArraySolution();
      int[] arr = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };

      Console.WriteLine(fadiaa.PrintList(fadiaas.FindDuplicates(arr)));
      */
      #endregion

      #region LongestSubstringWIthoutRepeatingCharacters
      /*
      LongestSubstringWithoutRepeatingCharactersSolution lswrcs = new LongestSubstringWithoutRepeatingCharactersSolution();
      string input = "abcabcbb";

      Console.WriteLine(lswrcs.LengthOfLongestSubstring(input));
      */
      #endregion

      // Unfinished
      #region WordSearchII
      /*
      WordSearchIISolution wsiis = new WordSearchIISolution();

      char[][] board = new char[4][];
      board[0] = new char[] { 'o', 'a', 'a', 'n' };
      board[1] = new char[] { 'e', 't', 'a', 'e' };
      board[2] = new char[] { 'i', 'h', 'k', 'r' };
      board[3] = new char[] { 'i', 'f', 'l', 'v' };

      string[] words = new string[] { "oath", "pea", "eat", "rain" };

      PrintArray<string>(wsiis.FindWords(board, words));
      Console.WriteLine();

      char[][] board2 = new char[2][];
      board2[0] = new char[] { 'a', 'b' };
      board2[1] = new char[] { 'c', 'd' };

      string[] words2 = new string[] { "abcb" };

      PrintArray<string>(wsiis.FindWords(board2, words2));
      Console.WriteLine();

      char[][] board3 = new char[3][];
      board3[0] = new char[] { 'a', 'b', 'c' };
      board3[1] = new char[] { 'a', 'e', 'd' };
      board3[2] = new char[] { 'a', 'f', 'g' };

      string[] words3 = new string[] { "eaafgdcba", "eaabcdgfa" };

      PrintArray<string>(wsiis.FindWords(board3, words3));
      Console.WriteLine();
      */
      #endregion

      #region BitwiseAndOfNumbersRange
      /*
      BitwiseAndOfNumbersRangeSolution baonrs = new BitwiseAndOfNumbersRangeSolution();

      Console.WriteLine(baonrs.RangeBitwiseAnd(5, 7));
      Console.WriteLine(baonrs.RangeBitwiseAnd(0, 0));
      Console.WriteLine(baonrs.RangeBitwiseAnd(0, 2147483647));
      Console.WriteLine(baonrs.RangeBitwiseAnd(2, 4));
      Console.WriteLine(baonrs.RangeBitwiseAnd(1, 1));
      Console.WriteLine(baonrs.RangeBitwiseAnd(2, 6));
      */
      #endregion

      #region LongestPalindromicSubstring
      /*
      //Example 1:
      //
      //Input: s = "babad"
      //Output: "bab"
      //Note: "aba" is also a valid answer.
      //
      //Example 2:
      //Input: s = "cbbd"
      //Output: "bb"
      //
      //Example 3:
      //
      //Input: s = "a"
      //Output: "a"
      //
      //Example 4:
      //
      //Input: s = "ac"
      //Output: "a"
      LongestPalindromicSubstringSolution lpss = new LongestPalindromicSubstringSolution();

      Console.WriteLine(lpss.LongestPalindrome("babad"));
      Console.WriteLine(lpss.LongestPalindrome("cbbd"));
      Console.WriteLine(lpss.LongestPalindrome("a"));
      Console.WriteLine(lpss.LongestPalindrome("ac"));
      */
      #endregion

      #region ReverseInteger
      /*
      ReverseIntegerSolution ris = new ReverseIntegerSolution();

      Console.WriteLine(ris.Reverse(123)); // 321
      Console.WriteLine(ris.Reverse(-123)); // -321
      Console.WriteLine(ris.Reverse(120)); // 21
      Console.WriteLine(ris.Reverse(0)); // 0
      */
      #endregion

      #region IntegerToRoman

      IntegerToRomanSolution itrs = new IntegerToRomanSolution();

      Console.WriteLine(itrs.IntToRoman(1));
      Console.WriteLine(itrs.IntToRoman(5));
      Console.WriteLine(itrs.IntToRoman(10));
      Console.WriteLine(itrs.IntToRoman(50));
      Console.WriteLine(itrs.IntToRoman(100));
      Console.WriteLine(itrs.IntToRoman(500));
      Console.WriteLine(itrs.IntToRoman(1000));

      Console.WriteLine(itrs.IntToRoman(3));
      Console.WriteLine(itrs.IntToRoman(58));
      Console.WriteLine(itrs.IntToRoman(1994));

      #endregion

    }
  }
}
