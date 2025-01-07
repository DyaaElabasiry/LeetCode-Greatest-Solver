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
    public int CountNodes(TreeNode root)
    {
        Stack<(TreeNode, int)> stack = new Stack<(TreeNode, int)>();
        TreeNode node;
        int level;
        int numOfTreeNodes = 0;
        int maxLevel = 0;
        int numOfLevelNodes = 0;
        if (root != null)
        {
            stack.Push((root, 0));
            node = root;
            while (node.right!=null)
            {
                maxLevel++;
                node = node.right;
            }
        }
        

        while (stack.Count != 0)
        {
            (node, level) = stack.Pop();
            Console.WriteLine($"{node.val}   {level}");
            if (level == maxLevel)
            {
                numOfLevelNodes++;
                Console.WriteLine($"level nodes    {numOfLevelNodes}");
            }

            if (node.left != null)
            {
                stack.Push((node.left, level + 1));
                if ((level+1)>maxLevel )
                {
                    if (node.right!=null)
                    {
                        Console.WriteLine($"compute on node {node.right.val}");
                        numOfTreeNodes = ((int)Math.Pow(2, maxLevel + 2) -1) -  2*numOfLevelNodes+2;
                        return numOfTreeNodes;
                    }
                    else
                    {
                        Console.WriteLine($"compute on node {node.left.val}");
                        numOfTreeNodes = ((int)Math.Pow(2, maxLevel + 2) -1 ) -  2*numOfLevelNodes+1;
                        return numOfTreeNodes;
                    }

                    break;
                }
            }

            if (node.right != null)
            {
                stack.Push((node.right, level + 1));
            }
        }

        if (numOfLevelNodes==(int)Math.Pow(2,maxLevel))
        {
            numOfTreeNodes = (int)Math.Pow(2, maxLevel + 1) - 1;
        }

        Console.WriteLine($"level nodes    {numOfLevelNodes}");
        Console.WriteLine($"max level      {maxLevel}");
        return numOfTreeNodes;
    }
}