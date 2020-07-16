namespace leetcode
{
    class Solution0026
    {
        //26.删除排序数组中的重复项
        //https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array/submissions/
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])//用快慢指针解决,后面的数覆盖前面的重复值.
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
    }
}