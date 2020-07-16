namespace leetcode
{
    class Solution0083
    {
        //83.删除排序链表中的重复元素
        //https://leetcode-cn.com/problems/remove-duplicates-from-sorted-list/
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
            {
                return head;
            }
            ListNode node = head;
            while (node.next != null)
            {
                if (node.next.val == node.val)
                {
                    node.next = node.next.next;
                }
                else
                {
                    node = node.next;
                }
            }
            return head;
        }
    }
}