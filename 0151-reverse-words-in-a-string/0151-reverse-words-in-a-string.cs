
using System.Text;

public class Solution {
    public string ReverseWords(string s)
    {
        StringBuilder result = new();
        
        int wordEnd;
        int ptr = s.Length - 1;
        while (ptr>=0)
        {
            while (ptr>=0 && s[ptr]==' ')
            {
                ptr--;
            }

            wordEnd = ptr;
            while (ptr >=0 && s[ptr]!= ' ')
            {
                ptr--;
            }

            for (int i = ptr+1; i <= wordEnd; i++)
            {
                result.Append(s[i]);
            }

            result.Append(' ');
        }
        
        result.Remove(result.Length-1,1);
        if (result[^1]==' ')
        {
            result.Remove(result.Length-1,1);
        }
        
        
        
        return result.ToString();
    }
}