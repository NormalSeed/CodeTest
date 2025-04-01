using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int comparable = 1;
        int multiplier = 1;
        while (true)
        {
            comparable *= multiplier;
            if (comparable > n)
                return multiplier - 1;
            else if(comparable == n)
                return multiplier;
            multiplier++;
        }
        answer = multiplier;
        return answer;
    }
}