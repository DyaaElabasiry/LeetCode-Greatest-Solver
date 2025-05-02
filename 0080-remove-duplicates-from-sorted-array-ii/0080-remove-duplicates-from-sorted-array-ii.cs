public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int uniqueElements = 1, n = nums[0];
        bool isAddedTwice = false;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != n)
            {
                isAddedTwice = false;
                n = nums[i];
                nums[uniqueElements] = n;
                uniqueElements++;
                
            }

            else if (nums[i] == n && !isAddedTwice)
            {
                isAddedTwice = true;
                nums[uniqueElements] = n;
                uniqueElements++;
            }
        }

        return uniqueElements;
    }
}