using System.Text;

public class Solution {
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
        {
            return strs[0];
        }
        int minLength = 200;
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < strs.Length; i++)
        {
            minLength = Math.Min(strs[i].Length, minLength);
        }

        char ch;
        bool found = false;
        int j;
        for (int i = 0; i < minLength && !found; i++)
        {
            ch = strs[0][i];
            for (j = 1; j < strs.Length && !found; j++)
            {
                if (strs[j][i]!=ch)
                {
                    found = true;
                }
            }

            if (!found)
            {
                stringBuilder.Append(ch);
            }
        }

        return stringBuilder.ToString();
    }
}
