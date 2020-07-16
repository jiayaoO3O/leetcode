using System.Collections.Generic;

namespace leetcode
{
    class Solution0155
    {
        //155.最小栈
        //https://leetcode-cn.com/problems/min-stack/
        public class MinStack
        {
            int[] stack = new int[10000];
            Stack<int> min = new Stack<int>();
            int i = -1;
            public MinStack() { }
            public void Push(int x)
            {
                if (min.Count == 0 || x <= min.Peek())
                {
                    min.Push(x);
                }
                stack[i++] = x;
            }

            public void Pop()
            {
                if (stack[i] == min.Peek())
                {
                    min.Pop();
                }
                i--;
            }
            public int Top()
            {
                return stack[i];
            }
            public int GetMin()
            {
                return min.Peek();
            }
        }
    }
}