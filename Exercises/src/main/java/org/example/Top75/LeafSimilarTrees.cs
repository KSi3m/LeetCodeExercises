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
public class LeafSimilarTrees {
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>();
        getLeafs(root1,list1);
        getLeafs(root2,list2);
        return list1.SequenceEqual(list2);

    }

    public void getLeafs(TreeNode root, List<int> list){
        if(root == null) return;
        if(root.left == null && root.right == null)
        {
             list.Add(root.val);
             return;
        }
        getLeafs(root.left,list);
        getLeafs(root.right,list);
    }
}

/*
Consider all the leaves of a binary tree, from left to right order, the values of those leaves form a leaf value sequence.



For example, in the given tree above, the leaf value sequence is (6, 7, 4, 9, 8).

Two binary trees are considered leaf-similar if their leaf value sequence is the same.

Return true if and only if the two given trees with head nodes root1 and root2 are leaf-similar.

 

Example 1:


Input: root1 = [3,5,1,6,2,9,8,null,null,7,4], root2 = [3,5,1,6,7,4,2,null,null,null,null,null,null,9,8]
Output: true
Example 2:


Input: root1 = [1,2,3], root2 = [1,3,2]
Output: false
*/