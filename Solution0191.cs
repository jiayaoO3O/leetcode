namespace leetcode
{
    class Solution0191
    {
        //191.位1的个数
        //https://leetcode-cn.com/problems/number-of-1-bits/
        public int HammingWeight(uint n)
        {
            // string s = Convert.ToString(n, 2);
            // int count = 0;
            // for (int i = 0; i < s.Length; i++)
            // {
            //     if (s[i] == '1')
            //     {
            //         count++;
            //     }
            // }
            // return count;
            int result = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((n & 1) == 1)
                {
                    result++;
                }
                n = n >> 1;
            }
            return result;
        }
    }
}