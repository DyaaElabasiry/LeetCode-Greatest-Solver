public class Solution {
    public int Jump(int[] nums)
    {
        int i = nums.Length - 2;
        int lastIndex = nums.Length - 1;
        int maxDistanceIndex = lastIndex;
        int count = 0;
        while (lastIndex>=0)
        {
            
            while (i>=0)
            {
                if ((lastIndex-i) <= nums[i])
                {
                    maxDistanceIndex = i;
                }

                i--;
            }

            if (maxDistanceIndex==lastIndex)
            {
                break;
            }

            lastIndex = maxDistanceIndex;
            i = lastIndex - 1;
            count++;
        }

        return count;
    }
}