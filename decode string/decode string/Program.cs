
using System.Text;




public class Solution {
    public string DecodeString(string s)
    {
        
        string result;
        (result, _) = Decode(1, 0, s);

        return result;
    }

    (string,int) Decode(int repeat,int i, string s)
    {
        StringBuilder sb = new StringBuilder();
        string result;
        string number;
        while ( i!=s.Length && s[i]!=']' )
        {
            if (char.IsDigit(s[i]))
            {
                number = "";
                while (char.IsDigit(s[i]))
                {
                    number += s[i];
                    i++;
                }
                int rpt = int.Parse(number);
                i += 1;
                (result, i) = Decode(rpt, i, s);
                sb.Append(result);
            }
            else
            {
                sb.Append(s[i]);
            }
            
            i++;
        }
        StringBuilder ret = new StringBuilder(); 
        ret.Insert(0, sb.ToString(), repeat);
        return (ret.ToString(), i);
    }
}