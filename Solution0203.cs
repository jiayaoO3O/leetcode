namespace leetcode
{
    class Solution0203
    {
        //203.删除链表中的节点
        //https://leetcode-cn.com/problems/remove-linked-list-elements/
        public ListNode RemoveElements(ListNode head, int val)
        {
            // ListNode p = new ListNode(-1)
            // {
            //     next = head
            // };
            // ListNode h = p;
            // while (p.next != null)
            // {
            //     if (p.next.val == val)
            //     {
            //         p.next = p.next.next;
            //         continue;
            //     }
            //     p = p.next;
            // }
            // return h.next;
            if (head == null)
            {
                return null;
            }
            if (head.val == val)
            {
                return RemoveElements(head.next, val);
            }
            else
            {
                head.next = RemoveElements(head.next, val);
            }
            return head;
        }
    }
}