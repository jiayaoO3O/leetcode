namespace leetcode
{
    class Solution0263
    {
        //263.丑数
        //https://leetcode-cn.com/problems/ugly-number/
        public bool IsUgly(int num)
        {
            if (num <= 1)
            {
                return (num == 1) ? true : false;
            }
            while (num % 2 == 0)
            {
                num /= 2;
            }
            while (num % 3 == 0)
            {
                num /= 3;
            }
            while (num % 5 == 0)
            {
                num /= 5;
            }
            return num == 1;
        }
    }
}