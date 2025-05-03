public class Solution
{
    public int HIndex(int[] citations)
    {
        int[] arr = new int[citations.Length + 1];
        foreach (var c in citations)
        {
            arr[Math.Min(c, citations.Length)]++;
        }

        int sum = 0;
        for (int i = citations.Length; i>0; i--)
        {
            sum += arr[i];
            if (sum >= i)
            {
                sum = i;
                break;
            }
        }

        return sum;
    }
}