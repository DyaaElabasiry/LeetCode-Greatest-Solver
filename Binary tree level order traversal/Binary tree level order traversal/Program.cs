
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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> levels = new List<IList<int>>();
        IList<IList<TreeNode>> levelNodes = new List<IList<TreeNode>>();
        int i = 1;
        if (root!=null)
        {
            levels.Add(new List<int>());
            levelNodes.Add(new List<TreeNode>{root});
        }

        while (levels.Count == i)
        {
            foreach (TreeNode node in levelNodes[i-1])
            {
                levels[i-1].Add(node.val);
                if (node.left!=null)
                {
                    if (levels.Count==i)
                    {
                        levels.Add(new List<int>());
                        levelNodes.Add(new List<TreeNode>{node.left});
                    }
                    else
                    {
                        levelNodes[i].Add(node.left);
                    }
                }

                if (node.right!=null)
                {
                    if (levels.Count==i)
                    {
                        levels.Add(new List<int>());
                        levelNodes.Add(new List<TreeNode>{node.right});
                    }
                    else
                    {
                        levelNodes[i].Add(node.right);
                    }
                }
            }

            i++;
        }
        
        return levels;
    }
}