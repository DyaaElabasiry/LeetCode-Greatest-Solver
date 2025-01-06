public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        dict.Add(nums[0], 0);
        int val;
        for (int i = 1; i < nums.Length; i++)
        {
            

            if (target > nums[i])
            {
                val = target - nums[i];
            }
            else
            {
                val = nums[i] - target;
            }
            val = target - nums[i];
            Console.WriteLine($"{val}");
            if (dict.ContainsKey(val))
            {
                int[] ret = { dict[val],i };
                return ret;
            }

            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }

        return nums;
    }
}