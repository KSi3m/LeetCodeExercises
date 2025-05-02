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
public class MaxDepthOfBinaryTree {
    public int MaxDepth(TreeNode root) {

        return traverse(root,0);

    }

    public int traverse(TreeNode node, int count)
    {
        if(node == null) return count;
        int l = traverse(node.left,count+1); 
        int r = traverse(node.right,count+1); 
        return l>r ? l :r;
    }
}

/*
Given the root of a binary tree, return its maximum depth.

A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.

 

Example 1:


Input: root = [3,9,20,null,null,15,7]
Output: 3
Example 2:

Input: root = [1,null,2]
Output: 2
*/