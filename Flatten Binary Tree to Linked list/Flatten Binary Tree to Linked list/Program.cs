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
    public void Flatten(TreeNode root)
    {
        preOrderTraversal(root);
    }

    TreeNode preOrderTraversal(TreeNode root)
    {
        //TreeNode  leftTail, rightTail;
        if (root != null)
        {
            //Console.WriteLine(root.val);
            TreeNode leftTail = preOrderTraversal(root.left);
            TreeNode rightTail = preOrderTraversal(root.right);
            if (root.left == null && root.right == null)
            {
                return root;
            }
            else if (root.right == null)
            {
                root.right = root.left;
                root.left = null;
                return leftTail;
            }
            else if (root.left == null)
            {
                return rightTail;
            }

            leftTail.right = root.right;
            root.right = root.left;
            root.left = null;
            return rightTail;
        }

        return null;
    }
}