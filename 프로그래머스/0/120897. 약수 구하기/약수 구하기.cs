using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> result = new List<int>();
        int measure = 1;
        while (measure <= n)
        {
            if(n % measure == 0)
            {
                result.Add(measure);
            }
            measure ++;
        }
        int[] answer = new int[result.Count];
        for(int i = 0; i < result.Count; i++)
        {
            answer[i] = result[i];
        }
        
        return answer;
    }
}