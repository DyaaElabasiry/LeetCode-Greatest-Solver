using System.Text;

var solution = new Solution();
solution.PredictPartyVictory("RD");
public class Solution
{
    public string PredictPartyVictory(string senate)
    {
        int radientCount = 0;
        int direCount = 0;

        int removeRadient = 0;
        int removeDire = 0;

        StringBuilder senates = new StringBuilder();

        for (int i = 0; i < senate.Length; i++)
        {
            if (senate[i] == 'R')
            {
                if (removeRadient == 0)
                {
                    senates.Append('R');
                    radientCount++;
                    removeDire++;
                }
                else
                {
                    removeRadient--;
                }
            }
            else   /// if dire or 'D'
            {
                if (removeDire == 0)
                {
                    senates.Append('D');
                    direCount++;
                    removeRadient++;
                }
                else
                {
                    removeDire--;
                }
            }
            
        }

        while (radientCount != 0 && direCount != 0)
        {
            /*Console.WriteLine($"{senates.ToString()}   {radientCount}    {direCount}");*/
            for (int i = 0; i < senates.Length; i++)
            {
                if (senates[i] == 'R')
                {
                    if (removeRadient == 0)
                    {
                        removeDire++;
                    }
                    else
                    {
                        senates.Remove(i, 1);
                        radientCount--;
                        removeRadient--;
                        i--;
                    }
                }
                else   /// if dire or 'D'
                {
                    if (removeDire == 0)
                    {
                        removeRadient++;
                    }
                    else
                    {
                        senates.Remove(i, 1);
                        direCount--;
                        removeDire--;
                        i--;
                    }
                }
            }
        }
        /*Console.WriteLine(senates.ToString());*/
        if (direCount == 0)
        {
            return "Radiant";
        }
        else
        {
            return "Dire";
        }
        
    }
}