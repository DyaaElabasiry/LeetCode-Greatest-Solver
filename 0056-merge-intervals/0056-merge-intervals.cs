public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> result = new();
        
        int i = 0;
        int j = 1;
        while (i < intervals.Length)
        {
            while (j < intervals.Length && intervals[i][1] >= intervals[j][0])
            {
                intervals[i][1] = Math.Max(intervals[i][1], intervals[j][1]);
                j++;
            }
            result.Add(intervals[i]);
            i=j++;
            

        }
        return result.ToArray();
    }
}