using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int comparable = 1;
        int multiplier = 1;
        while (comparable <= n)
        {
            comparable *= multiplier;
            multiplier++;
        }
        answer = multiplier - 2;
        return answer;
    }
}