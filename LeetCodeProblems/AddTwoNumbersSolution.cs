using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
  class AddTwoNumbersSolution
  {

    public int ListNodeCount(ListNode l)
    {
      int count = 0;
      while (l != null)
      {
        count++;
        l = l.next;
      }
      return count;
    }

    public ListNode ListNodeReverse(ListNode l)
    {
      List<int> list = new List<int>();

      while (l != null)
      {
        list.Add(l.val);
        l = l.next;
      }

      return GetListNodeFromList(list.ToArray());
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
      int l1Count = ListNodeCount(l1);
      int l2Count = ListNodeCount(l2);

      if (l1Count > l2Count)
      {
        int diff = l1Count - l2Count;
        ListNode temp = l2;
        while (temp.next != null)
        {
          temp = temp.next;
        }
        for (int i = 0; i < diff; i++)
        {
          temp.next = new ListNode(0, null);
          temp = temp.next;
        }

      }
      else if (l2Count > l1Count)
      {
        int diff = l2Count - l1Count;
        ListNode temp = l1;
        while (temp.next != null)
        {
          temp = temp.next;
        }
        for (int i = 0; i < diff; i++)
        {
          temp.next = new ListNode(0, null);
          temp = temp.next;
        }
      }

      Console.WriteLine("l1: " + PrintListNode(l1));
      Console.WriteLine("l2: " + PrintListNode(l2));

      ListNode prevNode = null;
      int carry = 0;

      while (l1 != null && l2 != null)
      {

        int l1Val = 0;
        int l2Val = 0;
        if (l1 != null)
          l1Val = l1.val;
        if (l2 != null)
          l2Val = l2.val;


        Console.WriteLine(l1Val + l2Val + carry);

        ListNode currNode = new ListNode((l1Val + l2Val + carry) % 10, prevNode);

        if (l1Val + l2Val + carry > 9)
        {
          carry = 1;
        }
        else
        {
          carry = 0;
        }

        prevNode = currNode;

        l1 = l1.next;
        l2 = l2.next;
      }

      if (carry > 0)
      {
        prevNode = new ListNode(carry, prevNode);
      }

      return ListNodeReverse(prevNode);
    }

    public ListNode GetListNodeFromList(int[] digits)
    {
      ListNode prevNode = null;
      for (int i = 0; i < digits.Length; i++)
      {
        ListNode currNode = new ListNode(digits[i], prevNode);

        prevNode = currNode;

      }
      return prevNode;
    }

    public int[] DigitsFromInt(int n)
    {
      string nString = n.ToString();
      int[] output = new int[nString.Length];

      for (int i = 0; i < output.Length; i++)
      {
        output[i] = Int32.Parse(nString.Substring(i, 1));
      }

      return output;
    }

    public string PrintListNode(ListNode l)
    {
      StringBuilder sb = new StringBuilder("[");
      while (l.next != null)
      {
        sb.Append(l.val + ", ");
        l = l.next;
      }
      sb.Append(l.val + "]");

      return sb.ToString();
    }
  }

  public class ListNode
  {
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
      this.val = val;
      this.next = next;
    }
  }
}
