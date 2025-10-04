public class Solution {
    public int FindMinArrowShots(int[][] points)
    {
        int numberOfCollections = 0;
        int collectionStart = 0;
        int i = 0;
        Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));
        while (i < points.Length)
        {
            numberOfCollections++;
            collectionStart = i;
            i++;
            while (i < points.Length && DoesIntersectWithCollection( collectionStart, i, points))
            {
                i++;
            }
        }
        return numberOfCollections; 
    }

    public bool AreOverlapping(int[] a, int[] b)
    {
        return b[0]>=a[0]  && b[0]<=a[1];
    }

    public bool DoesIntersectWithCollection(int collectionStart, int collectionEnd, int[][] points)
    {
        return points[collectionStart][1]>=points[collectionEnd][0];
    }
}