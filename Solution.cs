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