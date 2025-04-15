using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        int width = 0;
        int length = 0;
        for (int i = 0; i < dots.Length; i++)
        {
            if (dots[0, 0] != dots[i, 0] && dots[0, 1] != dots[i, 1])
            {
                width = Math.Abs(dots[0, 0] - dots[i, 0]);
                length = Math.Abs(dots[0, 1] - dots[i, 1]);
                break;
            }
        }
        
        answer = width * length;
        return answer;
    }
}