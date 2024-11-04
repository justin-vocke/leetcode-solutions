// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using Practice;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

int[] nums = [3, 0, 6, 1, 5];
int[] nums3 = [2, 3, 0, 1, 4];
int[] arr = { 12, 11, 13, 5, 6, 7 };
int[][] arr2 = [[1, 2], [3, 4], [2, 3]];
int sum = nums.Sum();
int testNum = 0;

var sorting = new Sorting();
var quickSort = new QuickSort();
//var containsDuplicate = solution.DecimalToBinary(testNum);
var solution = new Solution();
solution.FindLongestChain(arr2);
var test = "stop here";
//var sum = solution.FindSum(keyValuePairs);


public class Solution
{

    public bool IsPalindrome(string s)
    {
        Regex rgx = new Regex("[^A-Za-z0-9]+");
        s = rgx.Replace(s, "");
        s = s.ToLower();
        int lower = 0;
        int upper = s.Length-1;
        while (lower < upper)
        {
            if (s[lower] != s[upper])
            {
                return false;
            }
            lower++;
            upper--;
        }
        return true;

    }

    // Method to check if it's possible to form a palindrome
    public bool IsPalindromePossible(string s)
    {
        // ToDo: Write Your Code Here.
        int i = 0, removals = 0, j = s.Length - 1;

        while (i != j) 
        {
            if (s[i] == s[j]) 
            {
                j--;
                i++;
            }

        }
        return false;
    }

    public int FindLongestChain(int[][] pairs)
    {
        // Sort pairs based on their second element in ascending order
        Array.Sort(pairs, (a, b) => a[1] - b[1]);

        // Initialize the chain beginning with the first pair
        int chainLength = 0;
        int chainEnd = pairs[0][1];
        foreach (int[] pair in pairs) 
        {
            if (pair[0] > chainEnd) 
            {
                chainEnd = pair[1];
                chainLength++;
            }
        }

        return chainLength;  // Return the maximum chain length
    }

    public int MinAddToMakeValid(string S)
    {
        // ToDO: Write Your Code Here.
        int balance = 0, counter = 0;
        foreach (char c in S) 
        {
            if (c == '(') 
            {
                balance++;
            } 
            else 
            {
                balance--;
            }
            if (balance == -1) 
            {
                balance++;
                counter++;
            }
        }
        return counter + Math.Abs(balance);
       
    }

    public string LargestPaldinromicString(string str) 
    {
        Dictionary<char, int> count = new Dictionary<char, int>();
        //get count for each character
        foreach (var c in str)
        {
            if (count.ContainsKey(c)) 
            {
                count[c]++;
            }
            else 
            {
                count.Add(c, 1);
            }
        }

    }

    public ListNode ReverseList(ListNode head)
    {
        // TODO: Write your code here
        ListNode prev = null;
        ListNode current = head;
        while (current != null) 
        {
            current.Next = prev;
            prev = current;
            if(current.Next != null)
            {
                current = current.Next;
            }
            else
            {
                break;
            }
        }
        return head;
    }
    public class ListNode
    {
        public int Val;
        public ListNode Next;
        public ListNode(int x) { Val = x; }
    }

    

    public static void PrintArray(int[] arr)
    {
        /**
         * Utility function to print an array of size n
         */
        foreach (int i in arr)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}



