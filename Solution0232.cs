using System.Collections.Generic;

namespace leetcode
{
    class Solution0232
    {
        //232.用栈实现队列
        //https://leetcode-cn.com/problems/implement-queue-using-stacks/
        public class MyQueue
        {
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            public MyQueue()
            {
            }
            public void Push(int x)
            {
                while (stack1.Count != 0)
                {
                    stack2.Push(stack1.Pop());
                }
                stack1.Push(x);
                while (stack2.Count != 0)
                {
                    stack1.Push(stack2.Pop());
                }
            }
            public int Pop()
            {
                return stack1.Pop();
            }
            public int Peek()
            {
                return stack1.Peek();
            }
            public bool Empty()
            {
                return stack1.Count > 0 ? false : true;
            }
        }
    }
}