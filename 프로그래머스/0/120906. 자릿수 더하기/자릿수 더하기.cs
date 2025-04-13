using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        while (n > 0)
        {
            int k = 0;
            k = n % 10;
            answer += k;
            n /= 10;
        }
        
        return answer;
    }
}