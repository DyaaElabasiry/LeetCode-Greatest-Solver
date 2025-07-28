public class Solution
{
    private bool AreOverlaping(int[] a, int[] b)
    {
        return (a[0] >= b[0] && a[0] <= b[1]) || (b[0] >= a[0] && b[0] <= a[1]);
    }

    // merge and save in array a
    private void Merge(int[] a, int[] b)
    {
        a[0] = Math.Min(a[0], b[0]);
        a[1] = Math.Max(a[1], b[1]);
    }

    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        List<int[]> result = new(newInterval.Length + 1);
        int i = 0;
        while (i < intervals.Length && !AreOverlaping(intervals[i], newInterval) && newInterval[0] > intervals[i][0])
        {
            result.Add(intervals[i]);
            i++;
        }

        int j = i + 1;

        if (i == intervals.Length)
        {
            result.Add(newInterval);
        }
        else if (!AreOverlaping(intervals[i], newInterval))
        {
            result.Add(newInterval);
            result.Add(intervals[i]);
        }
        else
        {
            Merge(intervals[i], newInterval);

            while (j < intervals.Length && AreOverlaping(intervals[i], intervals[j]))
            {
                Merge(intervals[i], intervals[j]);
                j++;
            }

            result.Add(intervals[i]);
        }

        for (; j < intervals.Length; j++)
        {
            result.Add(intervals[j]);
        }


        return result.ToArray();
    }
}