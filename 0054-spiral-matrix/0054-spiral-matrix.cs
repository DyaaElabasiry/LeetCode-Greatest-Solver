
public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        bool[,] visited = new bool[matrix.Length, matrix[0].Length];
        List<int> result = new List<int>(matrix.Length * matrix[0].Length);
        visited[0, 0] = true;
        result.Add(matrix[0][0]);
        int x = 0,y = 0;
        do
        {
            (x, y) = right(matrix, visited, result, x, y);
            (x, y) = down(matrix, visited, result, x, y);
            (x, y) = left(matrix, visited, result, x, y);
            (x, y) = up(matrix, visited, result, x, y);
        } while (y + 1 < matrix[0].Length && !visited[x, y + 1]);

        
        return result;
    }

    public (int x,int y) right(int[][] matrix, bool[,] visited, List<int> result, int x, int y)
    {
        int cols = matrix[0].Length;
        while (y+1<cols && !visited[x,y+1]  )
        {
            y++;
            visited[x,y] = true;
            result.Add(matrix[x][y]);
        }
        return (x,y);
    }
    public (int x,int y) down(int[][] matrix, bool[,] visited, List<int> result, int x, int y)
    {
        int rows = matrix.Length;
        while (x+1<rows && !visited[x+1,y]  )
        {
            x++;
            visited[x,y] = true;
            result.Add(matrix[x][y]);
        }
        return (x,y);
    }
    public (int x,int y) left(int[][] matrix, bool[,] visited, List<int> result, int x, int y)
    {
        while (y-1>=0 && !visited[x,y-1]  )
        {
            y--;
            visited[x,y] = true;
            result.Add(matrix[x][y]);
        }
        return (x,y);
    }
    public (int x,int y) up(int[][] matrix, bool[,] visited, List<int> result, int x, int y)
    {
        int rows = matrix.Length;
        while (x-1>=0 && !visited[x-1,y]  )
        {
            x--;
            visited[x,y] = true;
            result.Add(matrix[x][y]);
        }
        return (x,y);
    }
}