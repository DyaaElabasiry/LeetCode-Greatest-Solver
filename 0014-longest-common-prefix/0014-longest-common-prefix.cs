using System.Text;

public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
        {
            return strs[0];
        }
        int minLength = 200;
        //StringBuilder stringBuilder = new StringBuilder();
        for (int j = 0; j < strs.Length; j++)
        {
            minLength = Math.Min(strs[j].Length, minLength);
        }

        //char ch;
        bool found = false;
        int i;
        for ( i = 0; i < minLength && !found; i++)
        {
            //ch = strs[0][i];
            for (int j = 1; j < strs.Length && !found; j++)
            {
                if (strs[j][i]!=strs[0][i])
                {
                    found = true;
                }
            }

            /*if (!found)
            {
                stringBuilder.Append(strs[0][i]);
            }*/
        }
        Console.WriteLine(i);
        return strs[0].Substring(0,minLength==0?0:!found?i:i-1);
    }
}