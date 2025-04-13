using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = -1;
        int digits = 1;
        int count = 0;
        int temp = num;
        while (temp > 0)
        {
            digits *= 10;
            temp /= 10;
            count++;
        }
        
        for (int i = 0; i < count; i++)
        {
            int n = 0;
            digits /= 10;
            n = num / digits;
            num -= digits * n;
            if (n == k)
            {
                answer = i + 1;
                break;
            }
        }
        
        return answer;
    }
}