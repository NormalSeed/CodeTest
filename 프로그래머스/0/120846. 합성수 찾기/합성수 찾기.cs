using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        for (int i = 1; i <= n; i++)
        {
            int num = 0;
            int j = 0;
            while(j <= i)
            {
                j++;
                if (i % j != 0)
                {
                    
                }
                else
                {
                    num++;
                }
            }
            if (num < 3)
                continue;
            else
            {
                answer++;
            }
        }
        return answer;
    }
}