var solution = new Solution();
solution.AddSpaces("LeetcodeHelpsMeLearn", [8, 13, 15]);
public class Solution {
    public string AddSpaces(string s, int[] spaces) {
        char[] charArray = new char[s.Length+spaces.Length];
        int j = 0;
        string str;
        for (int i = 0; i < charArray.Length; i++)
        {
            if (j < spaces.Length && i-j == spaces[j])
            {
                    charArray[i] = ' ';
                    j++;
            }
            else
            {
                charArray[i]=s[i-j]; 
            }
        }

        str = new string(charArray);
        return str;
    }
}