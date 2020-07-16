namespace leetcode
{
    class Solution0014
    {
        //14.最长公共前缀
        //https://leetcode-cn.com/problems/longest-common-prefix/comments/
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            if (strs.Length == 1)
            {
                return strs[0];
            }
            for (int i = 0; i < strs[0].Length; ++i)
            {
                for (int j = 1; j < strs.Length; ++j)
                {
                    if (strs[j].Length <= i || strs[0][i] != strs[j][i])
                    {
                        return strs[0].Substring(0, i);
                    }
                }
            }
            return strs[0];
        }
    }
}