// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Globalization;
using System.Text;


public class Solution1
{
    public int[] TwoSum(int[] nums, int target)
    {
        var num1 = 0;
        var num2 = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    num1 = i;
                    num2 = j;
                    break;
                }
                
            }
        }
        return [num1, num2];
    }
}

public class Solution2
{
    public bool IsPalindrome(int x)
    {
        var stringFromInt = x.ToString();
        var charArrayFromString = stringFromInt.ToCharArray();
        var charArrayReversed = charArrayFromString.Reverse().ToArray();
        var stringReversed = new string(charArrayReversed);
        return stringFromInt == stringReversed;
    }
}
