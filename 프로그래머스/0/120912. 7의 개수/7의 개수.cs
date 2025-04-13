using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        
        foreach(int n in array)
        {
            int temp = n;
            while (temp > 0)
            {
                if (temp % 10 == 7)
                {
                    answer += 1;
                }
                temp /= 10;
            }
        }
        
        return answer;
    }
}