using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int pieces = 0;
        do
        {
            pieces += 6;
            answer += 1;
        }
        while ( pieces % n != 0);
        return answer;
    }
}