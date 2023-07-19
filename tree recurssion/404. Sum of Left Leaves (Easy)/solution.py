class Solution:
    def sumOfLeftLeaves(self, root: Optional[TreeNode]) -> int:

        def right_help(node):
            if not node:
                return 0
            return left_help(node.left) + right_help(node.right)
        
        def left_help(node):
            if not node:
                return 0
            if node.left == None and node.right == None:
                return node.val
            else:
                return left_help(node.left) + right_help(node.right)

        if not root:
            return 0

        a = right_help(root.right)
        b = left_help(root.left)

        return a+b
