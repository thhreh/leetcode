# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isSymmetric(self, root: Optional[TreeNode]) -> bool:
        #helper function get left and right of root, then compare right to left, left to right
        def helper(node, reverse_node):
            if not node and not reverse_node:
                return True
            if not node or not reverse_node:
                return False
            if(node.val != reverse_node.val):
                return False
            return helper(node.left, reverse_node.right) and helper(node.right, reverse_node.left)

        if not root:
            return True
        
        
        
        return helper(root.left, root.right)
        
