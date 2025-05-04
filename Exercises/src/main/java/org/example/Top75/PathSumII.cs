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
public class PathSumII {
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        IList<IList<int>> finalList = new List<IList<int>>();
        traverse(root,targetSum,0, finalList,new List<int>());
        return finalList; 
    }
    public void traverse(TreeNode node, int targetSum, int sum, IList<IList<int>> finalList, IList<int> currentList) {
        if(node == null) return;
        currentList.Add(node.val);
        if(node.left == null && node.right == null && sum+node.val == targetSum)
        {
            finalList.Add(new List<int>(currentList));
        }

        traverse(node.left,targetSum,sum+node.val, finalList,currentList);
        traverse(node.right,targetSum,sum+node.val, finalList,currentList);  

        currentList.RemoveAt(currentList.Count - 1);

    }
}

/*
Given the root of a binary tree and an integer targetSum, return all root-to-leaf paths where the sum of the node values in the path equals targetSum. Each path should be returned as a list of the node values, not node references.

A root-to-leaf path is a path starting from the root and ending at any leaf node. A leaf is a node with no children.

 

Example 1:


Input: root = [5,4,8,11,null,13,4,7,2,null,null,5,1], targetSum = 22
Output: [[5,4,11,2],[5,8,4,5]]
Explanation: There are two paths whose sum equals targetSum:
5 + 4 + 11 + 2 = 22
5 + 8 + 4 + 5 = 22
Example 2:


Input: root = [1,2,3], targetSum = 5
Output: []
Example 3:

Input: root = [1,2], targetSum = 0
Output: []
 */