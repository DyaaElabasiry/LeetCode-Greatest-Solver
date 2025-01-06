// See https://aka.ms/new-console-template for more information
public class RecentCounter
{
    private Queue<int> queue;
    public RecentCounter() {
        queue = new Queue<int>();
    }
    
    public int Ping(int t)
    {
        queue.Enqueue(t);
        while (queue.Peek()<t-3000)
        {
            queue.Dequeue();
        }
        return queue.Count;
    }
}