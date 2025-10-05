public class Solution
{
    public bool Exist(char[][] board, string word)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j]==word[0] && discover(board, word, i, j, 0)) return true;
            }
        }

        return false;
    }

    bool discover(char[][] board, string word, int row, int col, int i)
    {
        if (i == word.Length - 1) return true;
        char original = board[row][col];
        board[row][col] = '#';
        if (row + 1 < board.Length && board[row+1][col] != '#' && board[row + 1][col] == word[i + 1] && discover(board, word, row + 1, col, i + 1))
        {
            board[row][col] = original;
            return true;
        }
        else if (row - 1 >= 0 && board[row-1][col] != '#' && board[row - 1][col] == word[i + 1] && discover(board, word, row - 1, col, i + 1))
        {
            board[row][col] = original;
            return true;
        }
        else if (col + 1 < board[0].Length && board[row][col+1] != '#' && board[row][col + 1] == word[i + 1] &&
                 discover(board, word, row, col + 1, i + 1))
        {
            board[row][col] = original;
            return true;
        }
        else if (col - 1 >= 0 && board[row][col-1] != '#' && board[row][col - 1] == word[i + 1] &&
                 discover(board, word, row, col - 1, i + 1))
        {
            board[row][col] = original;
            return true;
        }
        board[row][col] = original;
        return false;
    }
}