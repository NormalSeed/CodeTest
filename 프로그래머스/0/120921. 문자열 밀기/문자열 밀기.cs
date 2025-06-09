using System;

public class Solution {
    public int solution(string A, string B) {
        int answer = 0;
        
        answer = (B+B).IndexOf(A);
        
        return answer;
    }
}