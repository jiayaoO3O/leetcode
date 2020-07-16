using System.Collections.Generic;

namespace leetcode
{
    class Solution0205
    {
        //205.同构字符串
        //https://leetcode-cn.com/problems/isomorphic-strings/
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> strInfo = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!strInfo.ContainsKey(s[i]))
                {
                    if (strInfo.ContainsValue(t[i]))
                    {
                        return false;
                    }
                    strInfo.Add(s[i], t[i]);
                }
                else
                {
                    if (strInfo[s[i]] != t[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}