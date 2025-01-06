

public class Solution {
    char incrementChar(char ch)
    {
        if (ch == 'z')
        {
            return 'a';
        }

        int asciiValue = (int)ch;
        asciiValue++;
        return (char)asciiValue;
    }
    public bool CanMakeSubsequence(string str1, string str2)
    {
        int j = 0;
        bool isContained = false;
        for (int i = 0; i < str1.Length; i++)
        {
            if ( str1[i] == str2[j] || incrementChar(str1[i]) == str2[j] ) 
            {
                j++;
            }

            if (j == str2.Length)
            {
                isContained = true;
                break;
            }
        }

        return isContained;
    }
}