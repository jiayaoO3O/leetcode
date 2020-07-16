using System.Collections.Generic;

namespace leetcode
{
    class Solution0013
    {
        //13.罗马数字转整数
        //https://leetcode-cn.com/problems/roman-to-integer/comments/
        public int RomanToInt(string s)
        {

            Dictionary<char, int> romanNumber = new Dictionary<char, int> {
                { 'I', 1 },{ 'V', 5 },{ 'X', 10 },{ 'L', 50 },
                { 'C', 100 },{ 'D', 500 },{ 'M', 1000 }
            };
            int result = romanNumber[s[s.Length - 1]];
            for (int i = s.Length - 2; i >= 0; i--)
            {
                if (romanNumber[s[i]] < romanNumber[s[i + 1]])
                {
                    result -= romanNumber[s[i]];
                }
                else
                {
                    result += romanNumber[s[i]];
                }
            }
            return result;
        }
    }
}