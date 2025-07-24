public class BrowserHistory {
    List<string> list = new();
    int currentIndex = 0;
    public BrowserHistory(string homepage) {
        list.Add(homepage);
    }
    
    public void Visit(string url) {
        if (list.Count == currentIndex+1)
        {
            list.Add(url);
            currentIndex++;
        }
        else
        {
            list.RemoveRange(currentIndex+1, list.Count - currentIndex - 1);
            list.Add(url);
            currentIndex++;
        }
    }
    
    public string Back(int steps) {
        if (currentIndex - steps <= 0)
        {
            currentIndex = 0;
            return list[0];
        }
        else
        {
            currentIndex -= steps;
            return list[currentIndex];
        }
    }
    
    public string Forward(int steps) {
        if (currentIndex + steps >= list.Count)
        {
            currentIndex = list.Count - 1;
            return list[list.Count - 1];
        }
        else
        {
            currentIndex += steps;
            return list[currentIndex];
        }
    }
}