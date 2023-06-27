public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if(root == null){
            return null;
        }
        TreeNode temp = root.left;
        InvertTree(root.left);
        InvertTree(root.right);
        root.left = root.right;
        root.right = temp;
        return root;
        
    }
}
