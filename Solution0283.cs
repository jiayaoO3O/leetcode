namespace leetcode
{
    class Solution0283
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
    }
}