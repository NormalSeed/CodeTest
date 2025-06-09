using System;

public class Solution {
    public int solution(int M, int N) {
        int answer = 0;
        int n1 = 0;
        int n2 = 0;
        
        n1 = (M - 1) + M * (N - 1);
        n2 = (N - 1) + N * (M - 1);
        
        answer = Math.Max(n1, n2);
        
        return answer;
    }
}