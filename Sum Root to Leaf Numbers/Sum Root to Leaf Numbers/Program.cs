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
    public int totalSum = 0;

    public int SumNumbers(TreeNode root)
    {
        sumN(root, 0, 0);
        return totalSum;
    }

    public void sumN(TreeNode root, int sum, int level)
    {
        if (root != null)
        {
            sum = sum * 10 + root.val;
            
            if (root.left == null && root.right == null)
            {
                totalSum += sum;
                Console.WriteLine($"{sum}   {level }");
            }
            else
            {
                sumN(root.right, sum, level + 1);
                sumN(root.left, sum, level + 1);
            }
        }
    }
}