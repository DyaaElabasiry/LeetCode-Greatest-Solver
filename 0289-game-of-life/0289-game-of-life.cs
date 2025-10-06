public class Solution {
    public void GameOfLife(int[][] board) {
        int[][] boardCopy = new int[board.Length][];
        int[][] moves = new int[8][]
        {
            new int[] {-1,-1},
            new int[] {-1,0},
            new int[] {-1,1},
            new int[] {0,1},
            new int[] {1,1},
            new int[] {1,0},
            new int[] {1,-1},
            new int[] {0,-1}
        };
        for (int i = 0; i < board.Length; ++i)
        {
            boardCopy[i] = new int[board[i].Length];
            for (int j = 0; j < board[i].Length; ++j)
            {
                int count = 0;
                foreach (var move in moves)
                {
                    if (move[0] + i >= 0 && move[0] +i < board.Length && move[1] + j >= 0 &&
                        move[1] + j < board[0].Length)
                    {
                        if (board[move[0] + i][move[1]  + j] == 1) count++;
                    }
                }

                if (count == 3 || (count == 2 && board[i][j] == 1))
                {
                    boardCopy[i][j] = 1;
                }
                else
                {
                    boardCopy[i][j] = 0;
                }
                
            }
                
        }

        boardCopy.CopyTo(board, 0);
    }
}