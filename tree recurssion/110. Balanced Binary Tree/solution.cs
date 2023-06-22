public class Solution {
    public bool IsBalanced(TreeNode root) {
        if(root == null) {
            return true;
        }
        if(MaxDepth(root) == -1 ){
            return false;
       }
       
        return true;
    }
    public int MaxDepth(TreeNode root) {


        if(root == null){
            return 0;
        }
        int k = MaxDepth(root.left);
        
        int j = MaxDepth(root.right);

        if(k == -1 || j == -1){
            return -1;
        }
         if (Math.Abs(k - j) > 1)  return -1;

		return Math.Max(k, j) + 1;
        
    }
}
