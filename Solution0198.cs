namespace leetcode
{
    class Solution0198
    {
        //198.打家劫舍
        //https://leetcode-cn.com/problems/house-robber/
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }
            int[] sum = new int[nums.Length];
            sum[0] = nums[0];
            sum[1] = System.Math.Max(nums[0], nums[1]);
            for (int i = 2; i < sum.Length; i++)
            {
                sum[i] = System.Math.Max(sum[i - 1], sum[i - 2] + nums[i]);
            }
            return sum[sum.Length - 1];
        }
    }
}