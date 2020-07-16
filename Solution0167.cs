namespace leetcode
{
    class Solution0167
    {
        //167.两数之和 II - 输入有序数组
        //https://leetcode-cn.com/problems/two-sum-ii-input-array-is-sorted/
        public int[] TwoSumII(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while (left < right)
            {
                if (numbers[left] + numbers[right] == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                else
                {
                    if (numbers[left] + numbers[right] < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return new int[] { };
        }
    }
}