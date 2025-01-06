
public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int maxSum = 0;
        int currentMax = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i]==1)
            {
                currentMax++;
            }
            else
            {
                if (currentMax>maxSum)
                {
                    maxSum = currentMax;
                }

                currentMax = 0;
            }
        }

        if (currentMax>maxSum)
        {
            maxSum = currentMax;
        }

        return maxSum;
    }
}