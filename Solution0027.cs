namespace leetcode
{
    class Solution0027
    {
        //27.移除元素
        //https://leetcode-cn.com/problems/remove-element/
        public int RemoveElement(int[] nums, int val)
        {
            int n = nums.Length;
            for (int i = 0; i < n;)
            {
                if (nums[i] == val)
                {
                    n--;
                    nums[i] = nums[n];
                }
                else
                {
                    i++;
                }
            }
            return n;
        }
    }
}