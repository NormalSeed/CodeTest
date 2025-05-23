using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) {
        int[,] answer = new int[num_list.Length / n, n];
        for (int i = 0; i < num_list.Length / n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                answer[i, j] = num_list[(n * i) + j];
            }
        }
        return answer;
    }
}