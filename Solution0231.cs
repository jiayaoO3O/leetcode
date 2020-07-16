namespace leetcode
{
    class Solution0231
    {
        //231.2的幂
        //https://leetcode-cn.com/problems/power-of-two/
        public bool IsPowerOfTwo(int n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}