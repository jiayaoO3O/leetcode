using System.Collections.Generic;

namespace leetcode
{
    class Solution0217
    {
        //217.存在重复元素
        //https://leetcode-cn.com/problems/contains-duplicate/
        public bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return false;
            }
            System.Array.Sort(nums);
            // for (int i = 1; i < nums.Length; i++)
            // {
            //     if (nums[i] == nums[i - 1])
            //     {
            //         return true;
            //     }
            // }
            HashSet<int> numSet = new HashSet<int>();
            foreach (var num in nums)
            {
                if (numSet.Contains(num))
                {
                    return true;
                }
                else
                {
                    numSet.Add(num);
                }
            }
            return false;
        }
    }
}