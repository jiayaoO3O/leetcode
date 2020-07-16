using System;
using System.Collections.Generic;

namespace leetcode
{
    // public class ListNode
    // {
    //     public int val;
    //     public ListNode next;
    //     public ListNode(int x) { val = x; }
    // }
    // public class TreeNode
    // {
    //     public int val;
    //     public TreeNode left;
    //     public TreeNode right;
    //     public TreeNode(int x) { val = x; }
    // }
    class Solution
    {

        

        
        //242.有效的字母异位词
        //https://leetcode-cn.com/problems/valid-anagram/
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            // char[] str1 = s.ToCharArray();
            // char[] str2 = t.ToCharArray();
            // Array.Sort(str1);
            // Array.Sort(str2);
            // for (int i = 0; i < str1.Length; i++)
            // {
            //     if (str1[i] != str2[i])
            //     {
            //         return false;
            //     }
            // }
            // return true;
            var charDict = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (charDict.ContainsKey(c))
                {
                    charDict[c]++;
                }
                else
                {
                    charDict.Add(c, 1);
                }
            }
            foreach (var c in t)
            {
                if (charDict.ContainsKey(c))
                {
                    if (--charDict[c] == 0)
                    {
                        charDict.Remove(c);
                    }
                }
                else
                {
                    return false;
                }
            }
            return charDict.Count == 0;
        }

        //258.各位相加
        //https://leetcode-cn.com/problems/add-digits/
        public int AddDigits(int num)
        {
            if (num > 9)
            {
                num = num % 9;
                if (num == 0)
                {
                    return 9;
                }
            }
            return num;
            // if (num < 10)
            // {
            //     return num;
            // }
            // int result = 0;
            // while (num >= 10)
            // {
            //     result = 0;
            //     while (num != 0)
            //     {
            //         result += num % 10;
            //         num /= 10;
            //     }
            //     num = result;
            // }
            // return num;
        }

        //263.丑数
        //https://leetcode-cn.com/problems/ugly-number/
        public bool IsUgly(int num)
        {
            if (num <= 1)
            {
                return (num == 1) ? true : false;
            }
            while (num % 2 == 0)
            {
                num /= 2;
            }
            while (num % 3 == 0)
            {
                num /= 3;
            }
            while (num % 5 == 0)
            {
                num /= 5;
            }
            return num == 1;
        }

        //268.缺失数字
        //https://leetcode-cn.com/problems/missing-number/
        public int MissingNumber(int[] nums)
        {
            // Array.Sort(nums);
            // for (int i = 0; i < nums.Length; i++)
            // {
            //     if (i != nums[i])
            //     {
            //         return i;
            //     }
            // }
            // return nums[nums.Length - 1] + 1;
            int sum = (nums.Length * (nums.Length + 1)) / 2;
            for (int i = 0; i < nums.Length; i++)
            {
                sum -= nums[i];
            }
            return sum;
        }

        //278.第一个错误的版本
        //https://leetcode-cn.com/problems/first-bad-version/
        public int FirstBadVersion(int n)
        {
            int left = 1, right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
        private bool IsBadVersion(int mid) => throw new NotImplementedException();
        //这个函数放在这个位置是没有意义的.
        //唯一的目的是为了让代码不报错.
        //提交时不需要写这个函数.

        //283.移动零
        //https://leetcode-cn.com/problems/move-zeroes/
        public void MoveZeroes(int[] nums)
        {
            int flag = 0;
            foreach (int num in nums)
            {
                if (num != 0)
                {
                    nums[flag] = num;
                    flag += 1;
                }
            }
            for (int i = flag; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }

        //292.Nim游戏
        //https://leetcode-cn.com/problems/nim-game/
        public bool CanWinNim(int n)
        {
            return n % 4 != 0;
        }

        //326.3的幂
        //https://leetcode-cn.com/problems/power-of-three/
        public bool IsPowerOfThree(int n)
        {
            if (n == 0)
            {
                return false;
            }
            while (n % 3 == 0)
            {
                n /= 3;
            }
            return n == 1;
        }
    }
}