using System.Collections.Generic;

namespace leetcode
{
    class Solution0202
    {
        //202.快乐数
        //https://leetcode-cn.com/problems/happy-number/
        public bool IsHappy(int n)
        {
            int result = 0;
            HashSet<int> used = new HashSet<int>();
            while (!used.Contains(result))
            {
                used.Add(result);
                result = 0;
                while (n != 0)
                {
                    result = result + (n % 10) * (n % 10);
                    n = n / 10;
                }
                if (result == 1)
                {
                    return true;
                }
                n = result;
            }
            return false;
        }
    }
}