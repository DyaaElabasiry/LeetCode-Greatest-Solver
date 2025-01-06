public class Solution {
    public int ShortestSubarray(int[] nums, int k)
    {
        int shortestLength = -1;
        int firstIndex = 0;
        int lastIndex;
        Queue queue = new Queue();
        

        if (nums.Length == 1)
        {
            if (nums[0] >= k)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        while (nums[firstIndex] < 1)
        {
            firstIndex++;
        }
        lastIndex = firstIndex;
        queue.Enqueue(nums[firstIndex]);
        while ( firstIndex != nums.Length-1)
        {
            Console.WriteLine($"{firstIndex}   {lastIndex}  {shortestLength}");
            if (queue.Sum < k)
            {
                
                if (lastIndex == nums.Length-1 )
                {
                    queue.Dequeue(nums[firstIndex]);
                    firstIndex++;
                    if (queue.Length < shortestLength && queue.Sum >= k)
                    {
                        shortestLength = queue.Length;
                    }
                    
                }

                else{
                    lastIndex++;
                    queue.Enqueue(nums[lastIndex]);
                }
                
            }
            else
            {
                
                if (shortestLength == -1)
                {
                    shortestLength = queue.Length;
                }
                else if (queue.Length < shortestLength)
                {
                    shortestLength = queue.Length;
                }
                queue.Dequeue(nums[firstIndex]);
                firstIndex++;
            }
        }
        return shortestLength;
    }
    
    
}

public class Queue
{
    public int Length = 0;
    public int Sum = 0;

    public void Enqueue(int element)
    {
        Sum += element;
        Length++;
    }
    public void Dequeue(int element)
    {
        Sum -= element;
        Length--;
    }
    
}