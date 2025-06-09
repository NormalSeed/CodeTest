using System;

public class Solution {
    public int solution(int[] common) {
        int answer = 0;
        bool isArithmetic = false;
        bool isGeometric = false;
        
        if (common[2] - common[1] == common[1] - common[0])
        {isArithmetic = true;}
        else
        {
            isGeometric = true;
        }
        
        if (isArithmetic)
        {
            int diff = common[1] - common[0];
            answer = common[common.Length - 1] + diff;
        }
        else if(isGeometric)
        {
            int ratio = common[1] / common[0];
            answer = common[common.Length - 1] * ratio;
        }
        
        return answer;
    }
}