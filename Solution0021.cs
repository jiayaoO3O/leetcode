namespace leetcode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    class Solution0021
    {
        //21.合并两个有序链表
        //https://leetcode-cn.com/problems/merge-two-sorted-lists/comments/
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode node = new ListNode(0);
            ListNode head = node;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    node.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    node.next = l2;
                    l2 = l2.next;
                }
                node = node.next;
            }
            node.next = l1 == null ? l1 : l2;
            return head.next;
        }
    }
}