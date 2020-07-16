namespace leetcode
{
    class Solution0141
    {
        //141.环形链表
        //https://leetcode-cn.com/problems/linked-list-cycle/
        public bool HasCycle(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
                if (fast == slow)
                {
                    return true;
                }
            }
            return false;
        }
    }
}