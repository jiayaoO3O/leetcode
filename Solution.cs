using System;
using System.Collections.Generic;

namespace leetcode
{
    class Solution
    {
        //1.两数之和
        //https://leetcode-cn.com/problems/two-sum/
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { 0, 0 };
        }

        //7.整数反转
        //https://leetcode-cn.com/problems/reverse-integer/
        public int Reverse(int x)
        {
            int n = 0;
            int result = 0;
            while (x != 0)
            {
                result = n * 10 + x % 10;
                if (result / 10 != n)//不等于n说明溢出了.
                {
                    return 0;
                }
                x /= 10;
                n = result;
            }
            return result;
        }

        //9.回文数
        //https://leetcode-cn.com/problems/palindrome-number/
        public bool IsPalindrome(int x)
        {
            //直接转换字符串.
            // string str = x.ToString();
            // for (int i = 0; i < str.Length / 2; i++)
            // {
            //     if (str[i] != str[str.Length - i - 1])
            //     {
            //         return false;
            //     }
            // }
            // return true;
            if (x < 0)
            {
                return false;
            }
            else
            {
                int num = x;
                int result = 0;
                while (num != 0)
                {
                    result = result * 10 + num % 10;
                    num /= 10;
                }
                return result == x ? true : false;
            }
        }

        //13.罗马数字转整数
        //https://leetcode-cn.com/problems/roman-to-integer/comments/
        public int RomanToInt(string s)
        {

            Dictionary<char, int> romanNumber = new Dictionary<char, int> {
                { 'I', 1 },{ 'V', 5 },{ 'X', 10 },{ 'L', 50 },
                { 'C', 100 },{ 'D', 500 },{ 'M', 1000 }
            };
            int result = romanNumber[s[s.Length - 1]];
            for (int i = s.Length - 2; i >= 0; i--)
            {
                if (romanNumber[s[i]] < romanNumber[s[i + 1]])
                {
                    result -= romanNumber[s[i]];
                }
                else
                {
                    result += romanNumber[s[i]];
                }
            }
            return result;
        }

        //14.最长公共前缀
        //https://leetcode-cn.com/problems/longest-common-prefix/comments/
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            if (strs.Length == 1)
            {
                return strs[0];
            }
            for (int i = 0; i < strs[0].Length; ++i)
            {
                for (int j = 1; j < strs.Length; ++j)
                {
                    if (strs[j].Length <= i || strs[0][i] != strs[j][i])
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }
            return strs[0];
        }
    }
}