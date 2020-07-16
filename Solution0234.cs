namespace leetcode
{
    class Solution0234
    {
        //234.回文链表
        //https://leetcode-cn.com/problems/palindrome-linked-list/
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return true;
            }
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            ListNode newLinkedList = null;//创建一个新的链表.
            while (slow != null)
            {
                ListNode tempNode = slow.next;//创建临时链表存放头节点的尾巴.
                slow.next = newLinkedList;//将新链表接到头节点后面.
                newLinkedList = slow;//再次成为新链表.
                slow = tempNode;//将临时链表覆盖原链表.
            }
            slow = newLinkedList;
            while (slow != null)
            {
                if (slow.val != head.val)
                {
                    return false;
                }
                slow = slow.next;
                head = head.next;
            }
            return true;
        }
    }
}