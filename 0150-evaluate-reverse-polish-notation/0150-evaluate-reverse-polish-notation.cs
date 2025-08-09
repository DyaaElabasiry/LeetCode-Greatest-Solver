public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new();
        int num1;
        int num2;
        for (int i = 0; i < tokens.Length; i++)
        {
            if (tokens[i] != "+" && tokens[i] != "-" && tokens[i] != "*" && tokens[i] != "/")
            {
                stack.Push(int.Parse(tokens[i]));
            }
            else
            {
                num1 = stack.Pop();
                num2 = stack.Pop();
                if (tokens[i] == "+")
                {
                    stack.Push(num2 + num1);
                }
                else if (tokens[i] == "-")
                {
                    stack.Push(num2 - num1);
                }
                else if (tokens[i] == "*")
                {
                    stack.Push(num2 * num1);
                }
                else if (tokens[i] == "/")
                {
                    stack.Push(num2 / num1);
                }
            }
        }
        return stack.Pop();
    }
}