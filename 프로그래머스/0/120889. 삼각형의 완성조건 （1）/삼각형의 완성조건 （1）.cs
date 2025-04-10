using System;

public class Solution {
    public int solution(int[] sides) {
        int answer = 0;
        // 배열을 정렬해서 가장 긴 변이 마지막으로 오도록 함
        // 마지막 요소가 첫번째, 두번째 요소의 합보다 작으면 1, 크면 2를 answer에 반환
        Array.Sort(sides);
        
        if (sides[2] < sides[1] + sides[0])
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