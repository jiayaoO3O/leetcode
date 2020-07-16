namespace leetcode
{
    class Solution0268
    {
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
    }
}