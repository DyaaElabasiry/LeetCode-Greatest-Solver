// See https://aka.ms/new-console-template for more information

public class Solution {
    public bool CanChange(string start, string target)
    {
        int i = 0;
        int j = 0;
        int length = target.Length;
        while (i!=length || j!=length)
        {
            while (i<length && target[i]=='_')
            {
                i++;
            }
            
            while (j<length && start[j]=='_')
            {
                j++;
            }

            if (i == length)
            {
                if (i == j)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(j==length)
            {
                return false;
            }
            
            
            if (target[i] == start[j])
            {
                if (target[i]=='R')
                {
                    if (j>i)
                    {
                        return false;
                    }
                }
                else    // target letter = 'L'
                {
                    if (j < i)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            i++;
            j++;
        }

        return true;
    }
}