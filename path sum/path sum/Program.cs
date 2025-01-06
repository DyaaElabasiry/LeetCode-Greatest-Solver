public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        return pathSum(root, targetSum, 0);
    }

    public bool pathSum(TreeNode root, int targetSum, int comulativeSum)
    {
        if (root == null)
        {
            return false;
        }

        else if (root.val + comulativeSum == targetSum && root.left==null && root.right==null)
        {
            return true;
        }


        return pathSum(root.left, targetSum, root.val + comulativeSum) || pathSum(root.right, targetSum, root.val + comulativeSum);
    }
}