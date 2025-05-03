/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class PathSumI {
    public bool HasPathSum(TreeNode root, int targetSum) {
        return traverse(root,targetSum, 0);
    }
    public bool traverse(TreeNode node, int targetSum, int sum) {
        if(node == null) return false;
        if(node.left == null && node.right == null && sum+node.val == targetSum)
        {
            return true;
        }
        bool left = traverse(node.left,targetSum,sum+node.val);
        bool right = traverse(node.right,targetSum,sum+node.val);  

        return left || right;

    }
}

/*
Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.

A leaf is a node with no children.

 

Example 1:


Input: root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
Output: true
Explanation: The root-to-leaf path with the target sum is shown.
Example 2:


Input: root = [1,2,3], targetSum = 5
Output: false
Explanation: There are two root-to-leaf paths in the tree:
(1 --> 2): The sum is 3.
(1 --> 3): The sum is 4.
There is no root-to-leaf path with sum = 5.
Example 3:

Input: root = [], targetSum = 0
Output: false
Explanation: Since the tree is empty, there are no root-to-leaf paths.
 */