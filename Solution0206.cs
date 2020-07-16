namespace leetcode
{
    class Solution0206
    {
        //206.反转链表
        //https://leetcode-cn.com/problems/reverse-linked-list/
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            // ListNode newLinkedList = null;//创建一个新的链表.
            // while (head != null)
            // {
            //     ListNode tempNode = head.next;//创建临时链表存放头节点的尾巴.
            //     head.next = newLinkedList;//将新链表接到头节点后面.
            //     newLinkedList = head;//再次成为新链表.
            //     head = tempNode;//将临时链表覆盖原链表.
            // }
            // return newLinkedList;
            ListNode newLinkedList = ReverseList(head.next);//接收已经反转了的链表.
            head.next.next = head;//将2(head.next)的下一个节点(next)变为1(head).
            head.next = null;//将1(head)的下一个节点变为null.
            return newLinkedList;
        }
    }
}