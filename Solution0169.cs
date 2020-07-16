using System.Collections.Generic;

namespace leetcode
{
    class Solution0169
    {
        //169.求众数
        //https://leetcode-cn.com/problems/majority-element/
        public int MajorityElement(int[] nums)
        {
            // Array.Sort(nums);
            // return nums[nums.Length / 2];
            Dictionary<int, int> numsInfo = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (numsInfo.ContainsKey(num))
                {
                    numsInfo[num]++;
                }
                else
                {
                    numsInfo.Add(num, 1);
                }
                if (numsInfo[num] > nums.Length / 2)
                {
                    return num;
                }
            }
            return 0;
        }
    }
}