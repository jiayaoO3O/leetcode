namespace leetcode
{
    class Solution0237
    {
        //237.删除链表中的节点
        //https://leetcode-cn.com/problems/delete-node-in-a-linked-list/
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;//用下一个节点的数据覆盖当前节点.
            node.next = node.next.next;//删除下一个节点.
        }
    }
}