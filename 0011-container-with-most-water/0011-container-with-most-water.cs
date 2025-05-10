public class Solution {
    public int MaxArea(int[] height)
    {
        int maxArea = 0;
        int area;
        for (int i = 0; i < height.Length-1; i++)
        {
            for (int j = height.Length-1; j >i; j--)
            {
                area = (j - i) * Math.Min(height[i], height[j]);
                maxArea = Math.Max(maxArea,area);
                if (height[j]>height[i])
                {
                    break;
                }
            }
        }

        return maxArea;
    }
}