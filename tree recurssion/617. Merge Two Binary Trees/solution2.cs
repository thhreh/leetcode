public class Solution {
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        if (root1 == null & root2 == null) return null;
        if (root1 == null) return root2;
        if (root2 == null) return root1;

        var left = MergeTrees(root1.left, root2.left);
        var right = MergeTrees(root1.right, root2.right);

        if (root1.left != left) root1.left = left;
        if (root1.right != right) root1.right = right;

        root1.val += root2.val;

        return root1;
    }
}
