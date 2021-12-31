using System.Collections.Generic;

namespace LeetCodeProblems
{
  class IntegerToRomanSolution
  {
    /*
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




      return null;
    }

  }
}