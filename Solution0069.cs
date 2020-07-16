namespace leetcode
{
    class Solution0069
    {
        //69.x的平方分根
        //https://leetcode-cn.com/problems/sqrtx/
        //用牛顿迭代法求平方根非常好用,建议背下来.
        //https://www.guokr.com/question/461510/
        public int MySqrt(int x)
        {
            if (x <= 1)
            {
                return x;
            }
            double r = x;
            for (int i = 0; i < 20; i++)
            {
                r = (r + x / r) / 2;
            }
            return (int)r;
        }
    }
}