using System.Collections.Generic;

namespace leetcode
{
    class Solution0242
    {
        //242.有效的字母异位词
        //https://leetcode-cn.com/problems/valid-anagram/
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            // char[] str1 = s.ToCharArray();
            // char[] str2 = t.ToCharArray();
            // Array.Sort(str1);
            // Array.Sort(str2);
            // for (int i = 0; i < str1.Length; i++)
            // {
            //     if (str1[i] != str2[i])
            //     {
            //         return false;
            //     }
            // }
            // return true;
            var charDict = new Dictionary<char, int>();
            foreach (var c in s)
            {
                if (charDict.ContainsKey(c))
                {
                    charDict[c]++;
                }
                else
                {
                    charDict.Add(c, 1);
                }
            }
            foreach (var c in t)
            {
                if (charDict.ContainsKey(c))
                {
                    if (--charDict[c] == 0)
                    {
                        charDict.Remove(c);
                    }
                }
                else
                {
                    return false;
                }
            }
            return charDict.Count == 0;
        }
    }
}