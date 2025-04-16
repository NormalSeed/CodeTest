using System;

public class Solution {
    public int solution(int[,] board) {
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);
        int[][] directions = {
            new int[] {-1, -1}, new int[] {-1, 0}, new int[] {-1, 1},
            new int[] {0, -1}, new int[] {0, 1},
            new int[] {1, -1}, new int[] {1, 0}, new int[] {1, 1}
        };
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i, j] == 1)
                {
                    foreach (var dir in directions)
                    {
                        int ni = i + dir[0];
                        int nj = j + dir[1];
                        if (ni >= 0 && ni < rows && nj >= 0 && nj < cols && board[ni, nj] == 0)
                        {
                            board[ni, nj] = 2;
                        }
                    }

                }
            }
        }

        int answer = 0;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (board[i, j] == 0) {
                    answer++;
                }
            }
        }
        
        return answer;
    }
}