public class Solution {
    public int MaxDepth(TreeNode root) {
        int k = -1;
        int j = -1;
        if(root == null){
            return 0;
        }
        if(root.left == null && root.right == null){
            return 1;
        }
        if(root.left != null){
            k = MaxDepth(root.left);
        }
        if(root.right != null){
            j = MaxDepth(root.right);
        }
        if(k > j){
            return k+1;
        }else{return j+1;}
        
    }
}
