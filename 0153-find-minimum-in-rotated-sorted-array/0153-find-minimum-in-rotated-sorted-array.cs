public class Solution {
    public int FindMin(int[] nums) {
        int l = 0, r = nums.Length - 1,mid;
        while (l < r)
        {
            mid = l+(r-l) / 2;
            if (nums[mid] > nums[nums.Length-1])
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }
        return nums[l];
    }
}