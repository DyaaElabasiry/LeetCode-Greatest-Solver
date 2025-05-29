public class Solution {
    public bool CanJump(int[] nums)
    {
        int i = nums.Length - 2;
        int lastIndex = nums.Length - 1;
        while (i>=0)
        {
            if ((lastIndex-i)<=nums[i])
            {
                //Console.WriteLine($"index {i} of value {nums}");
                lastIndex = i;
            }

            i--;
        }

        return lastIndex == 0;
    }
}