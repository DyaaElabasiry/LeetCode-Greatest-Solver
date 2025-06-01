

public class Solution {
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] result = new int[nums.Length];
        result[0] = 1;
        for (int i = 1; i<result.Length; i++)
        {
            result[i] = nums[i - 1] * result[i - 1];
        }

        int rightProduct = 1;
        for (int i = result.Length-1; i >= 0; i--)
        {
            result[i] *= rightProduct;
            rightProduct *= nums[i];
        }

        return result;

    }
}