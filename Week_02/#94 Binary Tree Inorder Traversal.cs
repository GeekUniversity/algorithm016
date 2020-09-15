/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{

    private readonly IList<int> _ans = new List<int>();

    public IList<int> InorderTraversal(TreeNode root)
    {

        Helper(root);

        return _ans;
    }

    private void Helper(TreeNode root)
    {

        if (root == null) return;

        if (root.left != null) Helper(root.left);
        _ans.Add(root.val);
        if (root.right != null) Helper(root.right);
    }
}