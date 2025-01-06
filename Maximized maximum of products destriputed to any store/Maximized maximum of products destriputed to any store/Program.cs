// See https://aka.ms/new-console-template for more information

Solution solution = new Solution();
solution.MinimizedMaximum(7, [15,10,10]);
/*solution.GetMaxAndSecondMax([11,6]);*/


public class Solution {
    public int MinimizedMaximum(int n, int[] quantities)
    {
        if (quantities.Length == 1)
        {
            return quantities[0];
        }
        int numOfStores = quantities.Length;
        int[] maxValuesForEachType = (int[]) quantities.Clone();
        int[] numStoresForEachValue= Enumerable.Repeat(1, quantities.Length).ToArray();
        int max; int secondMax;
        int numStoresForMaxValue;
        int maxIndex;
        (max, secondMax , maxIndex) = GetMaxAndSecondMax(maxValuesForEachType);
        while (numOfStores <= n)
        {
            maxValuesForEachType[maxIndex] = max;
            (max, secondMax , maxIndex) = GetMaxAndSecondMax(maxValuesForEachType);
            if (max != secondMax)
            {
                numStoresForMaxValue = divide(quantities[maxIndex], secondMax);
            }
            else
            {
                numStoresForMaxValue = numStoresForEachValue[maxIndex]+1;
            }
            max = divide(quantities[maxIndex], numStoresForMaxValue);
            numOfStores = numOfStores + ( numStoresForMaxValue - numStoresForEachValue[maxIndex] );
            numStoresForEachValue[maxIndex] = numStoresForMaxValue;
            
            
            /*Console.WriteLine(maxIndex);
            Console.WriteLine(string.Join(", ", maxValuesForEachType));
            Console.WriteLine(string.Join(", ", numStoresForEachValue));*/

        }
        /*Console.WriteLine(maxValuesForEachType.Max());*/
        return maxValuesForEachType.Max();
    }
    
    public (int max, int secondMax, int maxIndex) GetMaxAndSecondMax(int[] array)
    {
        int max = int.MinValue;
        int secondMax = int.MinValue;
        int maxIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                secondMax = max;
                max = array[i];
                maxIndex = i;
            }
            else if (array[i] > secondMax )
            {
                secondMax = array[i];
            }
        }
        /*Console.WriteLine($"{max}  {secondMax}");*/
        return (max, secondMax, maxIndex);
    }

    public int divide(int num1, int num2)
    {
        return (int)Math.Ceiling((double)num1 / (double)num2);
    }
}


/*Console.WriteLine(string.Join(", ", productsInStore));*/