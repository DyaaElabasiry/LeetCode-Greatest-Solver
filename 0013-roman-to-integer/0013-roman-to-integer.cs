public class Solution {
    public int RomanToInt(string s)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        int sum = dic[s[0]];
        for (int i = 1; i < s.Length; i++)
        {
            if (dic[s[i]]<=dic[s[i-1]])
            {
                sum += dic[s[i]];
            }
            else
            {
                sum += dic[s[i]] - 2 * dic[s[i - 1]];
            }
        }

        return sum;
    }
}