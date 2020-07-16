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