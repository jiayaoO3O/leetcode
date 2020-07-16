using System.Collections.Generic;

namespace leetcode
{
    class Solution0020
    {
        //20.有效的括号
        //https://leetcode-cn.com/problems/valid-parentheses/
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        char symbol = stack.Pop();
                        if (s[i] == ')' && symbol != '(' || s[i] == ']' && symbol != '[' || s[i] == '}' && symbol != '{')
                        {
                            return false;
                        }
                    }
                }

            }
            return stack.Count == 0;
        }
    }
}