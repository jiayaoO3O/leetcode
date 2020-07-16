namespace leetcode
{
    class Solution0278
    {
        //278.第一个错误的版本
        //https://leetcode-cn.com/problems/first-bad-version/
        public int FirstBadVersion(int n)
        {
            int left = 1, right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
        private bool IsBadVersion(int mid) => throw new System.NotImplementedException();
        //这个函数放在这个位置是没有意义的.
        //唯一的目的是为了让代码不报错.
        //提交时不需要写这个函数.
    }
}