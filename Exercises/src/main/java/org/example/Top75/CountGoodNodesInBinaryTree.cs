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
public class CountGoodNodesInBinaryTree {
    public int GoodNodes(TreeNode root) {
        /*int k = 0;
        return traverse(root,ref k,root.val);*/
        return traverse2(root,root.val);
    }
    public int traverse(TreeNode node, ref int count, int max) {
        if(node == null) return count;
        if(node.val >= max) {
            max = node.val;
            count++;
        }
        traverse(node.left,ref count,max); 
        traverse(node.right,ref count,max); 
        return count;
        
    }
    public int traverse2(TreeNode node, int max) {
        if(node == null) return 0;
        int goodNodeCount = 0;
        if(node.val >= max) {
            max = node.val;
            goodNodeCount = 1;
        }
         
        goodNodeCount += traverse2(node.left, max); 
        goodNodeCount += traverse2(node.right, max); 
        return goodNodeCount;
        
    }
}

/*
Given a binary tree root, a node X in the tree is named good if in the path from root to X there are no nodes with a value greater than X.

Return the number of good nodes in the binary tree.

 

Example 1:



Input: root = [3,1,4,3,null,1,5]
Output: 4
Explanation: Nodes in blue are good.
Root Node (3) is always a good node.
Node 4 -> (3,4) is the maximum value in the path starting from the root.
Node 5 -> (3,4,5) is the maximum value in the path
Node 3 -> (3,1,3) is the maximum value in the path.
Example 2:



Input: root = [3,3,null,4,2]
Output: 3
Explanation: Node 2 -> (3, 3, 2) is not good, because "3" is higher than it.
Example 3:

Input: root = [1]
Output: 1
Explanation: Root is considered as good.
 */