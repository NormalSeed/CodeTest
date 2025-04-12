using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string[] splitS = my_string.Split(' ');
        List<int> numbers = new List<int>();
        List<string> operators = new List<string>();
        
        for (int i = 0; i < splitS.Length; i++)
        {
            if (i % 2 == 0)
            {
                numbers.Add(int.Parse(splitS[i]));
            }
            else
            {
                operators.Add(splitS[i]);
            }
        }
        
        for (int i = 0; i < operators.Count; i++)
        {
            if (operators[i] == "+")
            {
                numbers[i + 1] = numbers[i] + numbers[i + 1];
                answer = numbers[i + 1];
            }
            else if (operators[i] == "-")
            {
                numbers[i + 1] = numbers[i] - numbers[i + 1];
                answer = numbers[i + 1];
            }
        }
        
        return answer;
    }
}