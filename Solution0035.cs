namespace leetcode
{
    class Solution0035
    {
        //35.搜索插入位置
        //https://leetcode-cn.com/problems/search-insert-position/
        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    return i;
                }
            }
            return nums.Length;//如果前面的循环都找不到插入位置说明在最后面一个
        }
    }
}