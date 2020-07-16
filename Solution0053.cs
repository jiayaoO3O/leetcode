namespace leetcode
{
    class Solution0053
    {
        //53.最大子序和
        //https://leetcode-cn.com/problems/maximum-subarray/
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                sum = sum < 0 ? 0 : sum;

                max = sum > max ? sum : max;
            }
            return max;
        }
    }
}