public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        if (k > nums.Length)
        {
            k = k % nums.Length;
        }

        if (k > 0)
        {
            shiftRange(nums.Length - 1, k, nums);
        }

        //Console.WriteLine(string.Join(",", nums));
    }

    void shiftRange(int end, int shift, int[] array)
    {
        for (int i = 1; i <= (end + 1) / shift - 1; i++)
        {
            for (int j = 0; j < shift; j++)
            {
                (array[j], array[i * shift + j]) = (array[i * shift + j], array[j]);
            }
        }

        int remainder = (end + 1) % shift;
        for (int i = 0; i < remainder; i++)
        {
            (array[end - i], array[remainder - i - 1]) = (array[remainder - i - 1], array[end - i]);
        }

        if (remainder != 0)
        {
            shiftRange(shift - 1, shift - remainder, array);
        }
    }
}