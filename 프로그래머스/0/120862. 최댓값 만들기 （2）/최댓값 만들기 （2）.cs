using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        List<int> intList = new List<int>();
        
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                intList.Add(numbers[i] * numbers[j]);
            }
        }
        
        int[] result = new int[intList.Count];
        
        for (int i = 0; i < intList.Count; i++)
        {
            result[i] = intList[i];
        }
        
        Array.Sort(result);
        
        answer = result[result.Length - 1];
        
        return answer;
    }
}