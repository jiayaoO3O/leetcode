namespace leetcode
{
    class Solution0190
    {
        //190.颠倒二进制位
        //https://leetcode-cn.com/problems/reverse-bits/
        public uint reverseBits(uint n)
        {
            uint result = 0;
            for (int i = 0; i < 32; i++)
            {
                result <<= 1;
                result += n & 1;
                n >>= 1;
            }
            return result;
        }
    }
}