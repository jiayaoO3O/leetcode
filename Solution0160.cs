namespace leetcode
{
    class Solution0160
    {
        //160.相交链表
        //https://leetcode-cn.com/problems/intersection-of-two-linked-lists/
        public int CountNode(ListNode list)
        {
            int count = 0;
            while (list != null)
            {
                count++;
                list = list.next;
            }
            return count;
        }
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headB == null || headA == null)
            {
                return null;
            }
            int CountA = CountNode(headA);
            int CountB = CountNode(headB);
            if (CountA > CountB)
            {
                for (int i = 0; i < CountA - CountB; i++)
                {
                    headA = headA.next;
                }
            }
            else
            {
                for (int i = 0; i < CountB - CountA; i++)
                {
                    headB = headB.next;
                }
            }
            while (headA != null)
            {
                if (headA == headB)
                {
                    return headA;
                }
                headA = headA.next;
                headB = headB.next;
            }
            return null;
        }
    }
}