using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        int num = 1;
        
        for (int i = 1; i <= Math.Min(a, b); i++)
        {
            if (a % i == 0 && b % i == 0) num = i;
        }
        
        b /= num;
        
        while (b % 2 == 0) b /= 2;
        while (b % 5 == 0) b /= 5;
        
        if(b == 1)
        {
            answer = 1;
        }
        else
        {
            answer = 2;
        }
        
        return answer;
    }
}