

public class Solution {
    public int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(asteroids[0]);
        for (int i = 1; i < asteroids.Length; i++)
        {
            if (stack.Count==0)
            {
                stack.Push(asteroids[i]);
            }
            else if (stack.Peek() == -asteroids[i] && stack.Peek()>asteroids[i])
            {
                stack.Pop();
            }
            else if (stack.Peek()>0 && asteroids[i]<0)
            {
                
                if (-asteroids[i] > stack.Peek())
                {
                    stack.Pop();
                    i--;
                }
            }
            else
            {
                stack.Push(asteroids[i]);
            }
        }
        
        return stack.Reverse().ToArray();
    }
}