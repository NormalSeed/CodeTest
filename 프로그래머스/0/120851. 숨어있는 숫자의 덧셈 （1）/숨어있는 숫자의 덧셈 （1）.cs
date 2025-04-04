using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string my_string) {
        List<int> numbers = new List<int>();
        
        foreach(char c in my_string)
        {
            if(char.IsDigit(c))
            {
                numbers.Add(c - '0');
            }
        }
        
        int listCount = numbers.Count;
        int answer = 0;
        
        for (int i = 0; i < listCount; i++)
        {
            answer += numbers[i];
        }
        return answer;
    }
}