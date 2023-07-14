# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def minDepth(self, root: Optional[TreeNode]) -> int:
        def helper(node):
            if not node:
                return 10001
            if node.left == None and node.right == None:
                return 1
        
            a = helper(node.left) 
            b = helper(node.right)
            return min(a,b) + 1
        if not root:
            return 0
        return helper(root)
