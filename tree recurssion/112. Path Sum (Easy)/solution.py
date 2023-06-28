# Definition for a binary tree node.
# class TreeNode(object):
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution(object):
    def hasPathSum(self, root, targetSum):
        """
        :type root: TreeNode
        :type targetSum: int
        :rtype: bool
        """
        if not root:
            return False
        temp = self.hasPathSum(root.left,targetSum - root.val)
        temp2 = self.hasPathSum(root.right,targetSum - root.val)
        if(temp or temp2):
            return True
        if not root.left and not root.right and root.val == targetSum:
            return True
