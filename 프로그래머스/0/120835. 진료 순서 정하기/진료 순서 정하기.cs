using System;

public class Solution {
    public int[] solution(int[] emergency) {
        int[] answer = new int[emergency.Length];
        for (int i = 0; i < emergency.Length; i++)
        {
            int priority = 0;
            for (int j = 0; j < emergency.Length; j++)
            {
                if(emergency[i] <= emergency[j])
                {
                    priority++;
                }
            }
            answer[i] = priority;
        }
        return answer;
    }
}