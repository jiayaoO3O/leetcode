namespace leetcode
{
    class Solution0058
    {
        //58.最后一个单词的长度
        //https://leetcode-cn.com/problems/length-of-last-word/
        public int LengthOfLastWord(string s)
        {
            return s.Trim().Split()[s.Trim().Split().Length - 1].Length;
        }
    }
}