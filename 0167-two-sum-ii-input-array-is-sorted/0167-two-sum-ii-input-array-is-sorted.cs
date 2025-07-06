public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int l = 0;
        int r = numbers.Length - 1;
        int[] result = new int[2];
        while (l < r)
        {
            if (numbers[l] + numbers[r] == target)
            {
                result[0] = l + 1;
                result[1] = r + 1;
                break;
            }
            else if (numbers[l] + numbers[r] > target)
            {
                r--;
            }
            else
            {
                l++;
            }
        }

        return result;
    }
}