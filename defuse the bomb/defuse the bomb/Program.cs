using System.Globalization;

var solution = new Solution();
solution.Decrypt([2,4,9,3], -2);
public class Solution {
    public int[] Decrypt(int[] code, int k)
    {
        int length = code.Length;
        int[] output = new int[length];
        int sum = 0;
        int i=0;
        int j=0;
        if (k == 0)
        {
            return output;
        }else if (k > 0)
        {
            i = 1;
            j = k;
            
        }else if (k < 0)
        {
            i = length + k;
            j = length - 1;
            
        }
        for (int count = i; count <= j; count++)
        {
            sum += code[count];
        }

        output[0] = sum;
        for (int count = 1; count < length; count++)
        {
            sum -= code[i];
            i++;
            j++;
                
            if (i > length - 1)
            {
                i = 0;
            }
            if (j > length - 1)
            {
                j = 0;
            }
            sum += code[j];
            output[count] = sum;
                
                
        }

        return output;
    }
}