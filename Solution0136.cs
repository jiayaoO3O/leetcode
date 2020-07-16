namespace leetcode
{
    class Solution0136
    {
        //136.只出现一次的数字
        //https://leetcode-cn.com/problems/single-number/
        public int SingleNumber(int[] nums)
        {
            int n = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                n = n ^ nums[i];
            }
            return n;
        }
    }
}