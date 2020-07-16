namespace leetcode
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    class Solution0104
    {
        //104.二叉树的最大深度
        //https://leetcode-cn.com/problems/maximum-depth-of-binary-tree/
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                return 1 + System.Math.Max(MaxDepth(root.left), MaxDepth(root.right));
            }
        }
    }
}