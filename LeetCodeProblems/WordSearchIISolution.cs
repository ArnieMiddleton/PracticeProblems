using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
  class WordSearchIISolution
  {
    public IList<string> FindWords(char[][] board, string[] words)
    {
      int m = board.Length;
      int n = board[0].Length;
      HashSet<string> foundWords = new HashSet<string>();
      List<string> output = new List<string>();

      for (int i = 0; i < words.Length; i++)
      {
        char c = words[i][0];
        for (int x = 0; x < m; x++)
        {
          for (int y = 0; y < n; y++)
          {
            if (board[x][y] == c)
            {
              if (FindWordInBoard(board, x, y, words[i]))
                foundWords.Add(words[i]);
            }
          }
        }
      }
      foreach(string s in foundWords)
      {
        output.Add(s);
      }

      return output;
    }

    private bool FindWordInBoard(char[][] board, int x, int y, string word)
    {
      bool[][] visited = new bool[board.Length][];
      for (int i = 0; i < board.Length; i++)
      {
        visited[i] = new bool[board[0].Length];
        for (int j = 0; j < board[i].Length; j++)
        {
          visited[i][j] = false;
        }
      }

      if (FindNextCharRecursive(board, ref visited, x, y, word, 0))
      {
        return true;
      }

      return false;
    }

    private bool FindNextCharRecursive(char[][] board, ref bool[][] visited, int x, int y, string word, int wordIndex)
    {
      if (visited[x][y])
        return false;
      if (board[x][y] != word[wordIndex])
        return false;
      if (board[x][y] == word[^1] && wordIndex == word.Length - 1)
        return true;
      visited[x][y] = true; // becomes true even when the path doesn't result in a found word

      if (x > 0)
      {
        if (FindNextCharRecursive(board, ref visited, x - 1, y, word, wordIndex + 1))
          return true;
      }
      if (y > 0)
      {
        if (FindNextCharRecursive(board, ref visited, x, y - 1, word, wordIndex + 1))
          return true;
      }
      if (x < board.Length - 1)
      {
        if (FindNextCharRecursive(board, ref visited, x + 1, y, word, wordIndex + 1))
          return true;
      }
      if (y < board[0].Length - 1)
      {
        if (FindNextCharRecursive(board, ref visited, x, y + 1, word, wordIndex + 1))
          return true;
      }

      return false;
    }

    private void PrintBoard(char[][] board)
    {
      int m = board.Length;
      int n = board[0].Length;

      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          Console.Write(board[i][j] + " ");
        }
        Console.WriteLine();
      }
    }

    private void PrintBoard(bool[][] board)
    {
      int m = board.Length;
      int n = board[0].Length;

      for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
        {
          if (board[i][j])
            Console.Write("T ");
          else
            Console.Write("F ");
        }
        Console.WriteLine();
      }

    }
  }
}
