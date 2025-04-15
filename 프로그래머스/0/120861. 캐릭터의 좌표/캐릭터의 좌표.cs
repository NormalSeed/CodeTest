using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int[] answer = new int[2];
        int x = 0;
        int y = 0;
        for (int i = 0; i < keyinput.Length; i++)
        {
            switch(keyinput[i])
            {
                case "up":
                    if (board[1] / 2 > y)
                    {y += 1;}
                    break;
                case "down":
                    if (-board[1] / 2 < y)
                    {y -= 1;}
                    break;
                case "left":
                    if (-board[0] / 2 < x)
                    {x -= 1;}
                    break;
                case "right":
                    if (board[0] / 2 > x)
                    {x += 1;}
                    break;
            }
        }
        
        answer[0] = x;
        answer[1] = y;
        
        return answer;
    }
}