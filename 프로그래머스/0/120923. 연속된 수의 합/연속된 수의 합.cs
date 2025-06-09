using System;

public class Solution {
    public int[] solution(int num, int total) {
        int[] answer = new int[num];
        int factor = 0; //시작 수 f
        
        // num개의 연속된 수의 합 : (2f + n - 1) * n / 2
        // total = (2f + n - 1) * n / 2
        // ((2total / n) + 1 - n) / 2 = f
        factor = ((total * 2 / num) + 1 - num) / 2;
        
        for (int i = 0; i < num; i++)
        {
            answer[i] = factor + i;
        }
        
        return answer;
    }
}