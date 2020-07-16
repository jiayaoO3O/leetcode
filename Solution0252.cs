using System.Collections.Generic;

namespace leetcode
{
    class Solution0252
    {
        //225.用队列实现栈
        //https://leetcode-cn.com/problems/implement-stack-using-queues/
        public class MyStack
        {
            Queue<int> queue = new Queue<int>();
            public MyStack() { }
            public void Push(int x)
            {
                queue.Enqueue(x);
                for (int i = 0; i < queue.Count - 1; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
            }
            public int Pop()
            {
                return queue.Dequeue();
            }
            public int Top()
            {
                return queue.Peek();
            }
            public bool Empty()
            {
                return queue.Count > 0 ? false : true;
            }
        }
    }
}