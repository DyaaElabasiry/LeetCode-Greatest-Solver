


public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int CurrentMax = -1;
        int CurrentMin = prices[0];
        int LastMin = CurrentMin;
        int MaxP = 0;
        int secMaxP = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            /*Console.WriteLine($"{}");*/
            if (prices[i] < CurrentMin)
            {
                if (CurrentMax!=-1 && (CurrentMax-CurrentMin)>MaxP)
                {
                    MaxP = CurrentMax - CurrentMin;
                }else if (CurrentMax!=-1 && (CurrentMax-CurrentMin)>secMaxP)
                {
                    secMaxP = CurrentMax - CurrentMin;
                }
                CurrentMin = prices[i];
                CurrentMax = -1;
            }
            else if (prices[i] > CurrentMax)
            {
                CurrentMax = prices[i] ;
            }
        }
        if (CurrentMax!=-1 && (CurrentMax-CurrentMin)>MaxP)
        {
            MaxP = CurrentMax - CurrentMin;
        }else if (CurrentMax!=-1 && (CurrentMax-CurrentMin)>secMaxP)
        {
            secMaxP = CurrentMax - CurrentMin;
        }

        return MaxP+secMaxP;
    }
}