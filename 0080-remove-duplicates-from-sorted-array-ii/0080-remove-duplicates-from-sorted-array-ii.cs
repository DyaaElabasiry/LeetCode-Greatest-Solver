public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int uniqueElements = 1;
        if(nums.Length<=2){return nums.Length;}
        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] != nums[uniqueElements] || nums[uniqueElements] != nums[uniqueElements-1])
            {
                nums[++uniqueElements] = nums[i];
            }
            
        }

        return uniqueElements+1;
    }
}