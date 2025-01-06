



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
    private List<double> average = new List<double>();
    private List<int> count = new List<int>();

    public IList<double> AverageOfLevels(TreeNode root)
    {
        preOrderTraverse(root,0);
        return average;
    }
    
    public void preOrderTraverse(TreeNode root, int level)
    {
        if (root==null)
        {
            return;
        }
        if (average.Count==level)
        {
            average.Add( root.val);
            count.Add(1);
        }
        else
        {
            average[level] = (average[level]*count[level]+root.val)/(count[level]+1);
            count[level]++;
        }
        preOrderTraverse(root.left,level+1);
        preOrderTraverse(root.right,level+1);
    }
}





