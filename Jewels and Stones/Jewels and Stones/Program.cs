
public class Solution {
    public int NumJewelsInStones(string jewels, string stones)
    {
        var jewelsSet = new HashSet<char>();
        foreach (var ch in jewels)
        {
            jewelsSet.Add(ch);
        }

        int jewelsCount = 0;
        foreach (var ch in stones)
        {
            if (jewelsSet.Contains(ch))
            {
                jewelsCount++;
            }
        }
       

        return jewelsCount;
    }
}