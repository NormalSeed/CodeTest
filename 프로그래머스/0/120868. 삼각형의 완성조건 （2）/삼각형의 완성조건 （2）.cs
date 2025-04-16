using System;

public class Solution {
    public int solution(int[] sides) {
        int side = 0;
        int answer = 0;
        
        while(side < sides[0] + sides[1])
        {
            if(sides[0] + side <= sides[1])
            {
                side++;
            }
            else if(sides[1] + side <= sides[0])
            {
                side++;
            }
            else
            {
                answer ++;
                side++;
            }
        }
        
        
        return answer;
    }
}