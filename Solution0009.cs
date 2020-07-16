namespace leetcode
{
    class Solution0009
    {
        //9.回文数
        //https://leetcode-cn.com/problems/palindrome-number/
        public bool IsPalindrome(int x)
        {
            //直接转换字符串.
            // string str = x.ToString();
            // for (int i = 0; i < str.Length / 2; i++)
            // {
            //     if (str[i] != str[str.Length - i - 1])
            //     {
            //         return false;
            //     }
            // }
            // return true;
            if (x < 0)
            {
                return false;
            }
            else
            {
                int num = x;
                int result = 0;
                while (num != 0)
                {
                    result = result * 10 + num % 10;
                    num /= 10;
                }
                return result == x ? true : false;
            }
        }
    }
}