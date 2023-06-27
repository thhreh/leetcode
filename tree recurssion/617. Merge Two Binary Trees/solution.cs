public class Solution {
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
        if(root1 == null){
            return root2;
        }
        if(root2 == null){
            return root1;
        }
        TreeNode output = new TreeNode(build(root1,root2),MergeTrees(root1.left,root2.left),MergeTrees(root1.right,root2.right));
        return output;
    }
    //public TreeNode builder(TreeNode root1, TreeNode root2) {
        //TreeNode temp = new TreeNode(build(root1,root2),builder(root1.left,root2.left),builder(root1.right,root2.right));
        //return temp;

    //}

    public int build(TreeNode root1, TreeNode root2) {
        if(root1 == null && root2 == null){
            return 0;
        }
        else if(root1 == null){
            return root2.val;
        }
        else if(root2 == null){
            return root1.val;
        }else{
            return root1.val + root2.val;
        }

    }
}
