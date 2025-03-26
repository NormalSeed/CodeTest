using System;

public class Solution {
    public int[] solution(int money) {
        int[] answer = new int[2];
        int cups = money / 5500;
        int changes = money % 5500;
        answer[0] = cups;
        answer[1] = changes;
        
        return answer;
    }
}