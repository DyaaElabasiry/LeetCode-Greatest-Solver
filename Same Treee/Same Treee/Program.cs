


  using System.Text.RegularExpressions;

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

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p==null && q==null)
        {
            return true;
        }else if (p==null || q==null || p.val!=q.val )
        {
            return false;
        }
        else
        {
            return IsSameTree(q.left, p.left) && IsSameTree(q.right, p.right);
        }
    }
}