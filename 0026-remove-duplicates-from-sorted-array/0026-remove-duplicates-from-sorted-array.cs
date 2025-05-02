public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int uniqueElements = 1, n = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != n)
            {
                n = nums[i];
                nums[uniqueElements] = n;
                uniqueElements++;
            }
        }

        return uniqueElements;
    }
}