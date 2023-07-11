# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isSubtree(self, root: Optional[TreeNode], subRoot: Optional[TreeNode]) -> bool:
        def helper(p,q):

            if p == None and q == None : return True
            if p == None or q == None : return False
            if p.val != q.val : return False
            return helper(p.left,q.left) and helper(p.right,q.right)

        def dfs(node):
            if not node:
                return
            a = dfs(node.left)
            b = dfs(node.right)
            if(a or b):
                return True
            else:
                if(node.val == subRoot.val):
                    return helper(node,subRoot)
            return False
        

        if not root:
            return
        
        return dfs(root)
