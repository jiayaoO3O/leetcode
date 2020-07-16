namespace leetcode
{
    class Solution0100
    {
        //100.相同的树
        //https://leetcode-cn.com/problems/same-tree/
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if (p == null && q != null || p != null && q == null)
            {
                return false;
            }
            if (p.val != q.val)
            {
                return false;
            }
            else
            {
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }
        }
    }
}