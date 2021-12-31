using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
  class IntegerToRomanSolution
  {
    /*
    
    Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. Because the one is before the five we subtract it making four. The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

    I can be placed before V (5) and X (10) to make 4 and 9. 
    X can be placed before L (50) and C (100) to make 40 and 90. 
    C can be placed before D (500) and M (1000) to make 400 and 900.

    Given an integer, convert it to a roman numeral.


    Example 1:

    Input: num = 3
    Output: "III"
    Explanation: 3 is represented as 3 ones.
    Example 2:

    Input: num = 58
    Output: "LVIII"
    Explanation: L = 50, V = 5, III = 3.
    Example 3:

    Input: num = 1994
    Output: "MCMXCIV"
    Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 

    Constraints:

    1 <= num <= 3999
    */

    public string IntToRoman(int num)
    {
      Dictionary<int, char> symbols = new Dictionary<int, char>
      {
        [1] = 'I',
        [5] = 'V',
        [10] = 'X',
        [50] = 'L',
        [100] = 'C',
        [500] = 'D',
        [1000] = 'M'
      };

      string numString = num.ToString();
      StringBuilder romanString = new StringBuilder();

      int[] digits = new int[] { 0, 0, 0, 0 };

      // converts the numbeer into a series of inverted digits with 0s in all empty spaces for valid values
      while (numString.Length < 4)
      {
        numString = "0" + numString;
      }

      for (int i = 0; i < numString.Length; i++)
      {
        digits[digits.Length - i - 1] = Int32.Parse(numString.Substring(i, 1));
      }



      for (int i = 0; i < digits.Length; i++)
      {
        int digit = digits[i];
        switch (i)
        {
          case 0:
            if (digit < 4)
            {
              for (int j = 0; j < digit; j++)
              {
                romanString.Insert(0, "I");
              }
            }
            else if (digit == 4)
            {
              romanString.Insert(0, "IV");
            }
            else if (digit < 9)
            {
              for (int j = 5; j < digit; j++)
              {
                romanString.Insert(0, "I");
              }
              romanString.Insert(0, "V");
            }
            else if (digit == 9)
            {
              romanString.Insert(0, "IX");
            }
            break;
          case 1:
            if (digit < 4)
            {
              for (int j = 0; j < digit; j++)
              {
                romanString.Insert(0, "X");
              }
            }
            else if (digit == 4)
            {
              romanString.Insert(0, "XL");
            }
            else if (digit < 9)
            {
              for (int j = 5; j < digit; j++)
              {
                romanString.Insert(0, "X");
              }
              romanString.Insert(0, "L");
            }
            else if (digit == 9)
            {
              romanString.Insert(0, "XC");
            }
            break;
          case 2:
            if (digit < 4)
            {
              for (int j = 0; j < digit; j++)
              {
                romanString.Insert(0, "C");
              }
            }
            else if (digit == 4)
            {
              romanString.Insert(0, "CD");
            }
            else if (digit < 9)
            {
              for (int j = 5; j < digit; j++)
              {
                romanString.Insert(0, "C");
              }
              romanString.Insert(0, "D");
            }
            else if (digit == 9)
            {
              romanString.Insert(0, "CM");
            }
            break;
          case 3:
            for (int j = 0; j < digit; j++)
            {
              romanString.Insert(0, "M");
            }
            break;
        }
      }

      return romanString.ToString();
    }

  }
}