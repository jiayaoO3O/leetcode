using System;

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
    }
}