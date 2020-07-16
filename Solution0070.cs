namespace leetcode
{
    class Solution0070
    {
        //70.爬楼梯
        //https://leetcode-cn.com/problems/climbing-stairs/
        //这一题是很典型的动态规划问题,可以去看看这个推文:
        //https://mp.weixin.qq.com/s/3h9iqU4rdH3EIy5m6AzXsg
        public int ClimbStairs(int n)
        {
            //if (n==1||n==0)//递归操作;
            //{
            //    return 1;
            //}
            //else
            //{
            //    return ClimbStairs(n - 1) + ClimbStairs(n - 2);
            //}
            if (n == 1 || n == 0 || n == 2)
            {
                return n;
            }
            int[] r = new int[n + 1];//定义一个数组,接收每一层楼梯的走法
            r[1] = 1;
            r[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                r[i] = r[i - 1] + r[i - 2];
            }
            return r[n];
        }
    }
}