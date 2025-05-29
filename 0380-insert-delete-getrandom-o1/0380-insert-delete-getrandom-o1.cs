public class RandomizedSet
{
    private Dictionary<int,int> dictionary = new Dictionary<int, int>();
    private List<int> list = new List<int>();
    private Random random = new Random();
    public RandomizedSet()
    {
        
    }
    
    public bool Insert(int val) {
        if (dictionary.ContainsKey(val))
        {
            return false;
        }
        else
        {
            list.Add(val);
            dictionary.Add(val,list.Count-1);
            return true;
        }
    }
    
    public bool Remove(int val) {
        if (!dictionary.ContainsKey(val))
        {
            return false;
        }
        else
        {
            //update index of last element
            dictionary[list[^1]] = dictionary[val];
            //update val in list with the last index
            list[dictionary[val]] = list[^1];
            // remove val from the dictionary and las element from the list
            dictionary.Remove(val);
            list.RemoveAt(list.Count -1);
            return true;
        }
    }
    
    public int GetRandom()
    {
        int index = random.Next(list.Count );
        return list[index];
    }
}

