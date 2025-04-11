using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int order) {
        int answer = 0;
        List<int> digits = new List<int>();
        while (order > 0)
        {
            digits.Add(order % 10);
            order /= 10;
        }
        foreach (int d in digits)
        {
            if (d == 3 || d == 6 || d == 9)
            {
                answer += 1;
            }
        }
        return answer;
    }
}