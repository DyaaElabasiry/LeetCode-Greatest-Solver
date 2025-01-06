

  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 
public class Solution
{
    private List<int> rightNodes = new List<int>();
    public IList<int> RightSideView(TreeNode root)
    {
        preOrderTraverse(root,0);
        return rightNodes;
    }

    public void preOrderTraverse(TreeNode root, int level)
    {
        if (root==null)
        {
            return;
        }
        if (rightNodes.Count==level)
        {
            rightNodes.Add( root.val);
        }
        else
        {
            rightNodes[level] = root.val;
        }
        preOrderTraverse(root.left,level+1);
        preOrderTraverse(root.right,level+1);
    }
}