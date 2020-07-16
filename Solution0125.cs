namespace leetcode
{
    class Solution0125
    {
        //125.验证回文串
        //https://leetcode-cn.com/problems/valid-palindrome/
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();
            System.Text.StringBuilder result = new System.Text.StringBuilder();
            foreach (var c in s)
            {
                if (c >= 'a' && c <= 'z' || c >= '0' && c <= '9')
                {
                    result.Append(c);
                }
            }
            for (int i = 0; i < result.Length / 2; i++)
            {
                if (result[i] != result[result.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}