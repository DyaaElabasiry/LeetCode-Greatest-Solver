public class LRUCache
{
    private int capacity;
    private LinkedList<(int key,int value)> linkedList = new();
    private Dictionary<int, LinkedListNode<(int key,int value)>> dic = new();
    
    public LRUCache(int capacity)
    {
        this.capacity = capacity;
    }
    
    public int Get(int key) {
        if (dic.ContainsKey(key))
        {
            linkedList.Remove(dic[key]);
            linkedList.AddFirst(dic[key]);
            return dic[key].Value.value;
        }
        else
        {
            return -1;
        }
    }
    
    public void Put(int key, int value) {
        if (dic.ContainsKey(key))
        {
            linkedList.Remove(dic[key]);
            linkedList.AddFirst(dic[key]);
            dic[key].Value = (key,value);

        }
        else
        {
            linkedList.AddFirst(new LinkedListNode<(int key,int value)>((key,value)));
            dic.Add(key,linkedList.First);
        }
        if (linkedList.Count > capacity)
        {
            dic.Remove(linkedList.Last.Value.key);
            linkedList.RemoveLast();
        }
        
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */