
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
    public bool IsValidBST(TreeNode root) {
        Int64 min = (Int64)Int32.MinValue-1;
        Int64 max = (Int64)Int32.MaxValue+1;
        return Validate(root, min, max);
    }

    public bool Validate(TreeNode root, Int64 min, Int64 max)
    {
        if (root == null)
        {
            return true;
        }

        if (root.val <= min || root.val>=max)
        {
            //Console.WriteLine(root.val);
            return false;
        }

        return Validate(root.left,min,root.val) && Validate(root.right,root.val,max);
    }
}