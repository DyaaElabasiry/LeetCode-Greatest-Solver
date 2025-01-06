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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        TreeNode node;
        IList<IList<int>> levels = new List<IList<int>>();
        if (root!=null)
        {
        queue.Enqueue(root);
            
        }
        int queueCount;
        while (queue.Count!=0)
        {
            var list = new List<int>();
            queueCount = queue.Count;
            for (int i = 0; i < queueCount; i++)
            {
                
                node = queue.Dequeue();
                list.Add(node.val);
                if (node.left!=null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right!=null)
                {
                    queue.Enqueue(node.right);
                }
                
            }
            if (levels.Count%2 ==0)
            {
                levels.Add(list);
            }
            else
            {
                list.Reverse();
                levels.Add(list);
            }
        }

        return levels;

    }
}