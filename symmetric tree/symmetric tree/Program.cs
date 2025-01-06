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
    public bool IsSymmetric(TreeNode root)
    {
        return areSymmetric(root.left, root.right);
    }

    public bool areSymmetric(TreeNode p, TreeNode q)
    {
        if (q == null && p == null)
        {
            return true;
        }
        else if (p == null || q == null || p.val != q.val)
        {
            return false;
        }
        else
        {
            return areSymmetric(p.right, q.left) && areSymmetric(p.left, q.right);
        }
    }
}