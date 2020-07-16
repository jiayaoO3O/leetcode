namespace leetcode
{
    class Solution0172
    {
        //172.阶乘后的零
        //https://leetcode-cn.com/problems/factorial-trailing-zeroes/
        public int TrailingZeroes(int n)
        {
            int count = 0;
            while (n > 1)
            {
                count = count + n / 5;
                n = n / 5;
            }
            return count;
        }
    }
}