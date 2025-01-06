


using System.Text;

public class Solution {
    public string RemoveStars(string s)
    {
        StringBuilder str = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i]!='*')
            {
                str.Append(s[i]);
            }
            else
            {
                str.Remove(str.Length - 1, 1);
            }
        }

        return str.ToString();
    }
}