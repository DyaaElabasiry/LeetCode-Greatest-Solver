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
    public TreeNode InvertTree(TreeNode root)
    {
        if (root==null)
        {
            return null;
        }
        TreeNode Invertedroot = new TreeNode(root.val);
        /*Invertedroot.left = root.right;
        Invertedroot.right = root.left;*/
        treeInvertion(root, Invertedroot);
        return Invertedroot;
    }

    public void treeInvertion(TreeNode root, TreeNode copy)
    {
        Console.WriteLine("entered function");
        if (root == null)
        {
            copy = null;
        }
        else
        {
            copy.val = root.val;
            if (root.left != null)
            {
                TreeNode Invertedright = new TreeNode();
                copy.right = Invertedright;
                treeInvertion(root.left, copy.right);
            }

            if (root.right != null)
            {
                TreeNode Invertedleft = new TreeNode();
                copy.left = Invertedleft;

                treeInvertion(root.right, copy.left);
            }
        }
    }
}