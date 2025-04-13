using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        List<int> result = new List<int>();
        
        for (int i = 0; i < numlist.Length; i++)
        {
            if (numlist[i] % n == 0)
            {
                result.Add(numlist[i]);
            }
        }
        int[] answer = new int[result.Count];
        
        for (int i = 0; i < result.Count; i++)
        {
            answer[i] = result[i];
        }
        
        return answer;
    }
}