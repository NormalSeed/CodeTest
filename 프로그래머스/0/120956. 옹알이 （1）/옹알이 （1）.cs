using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string str;
        
        for(int i = 0; i < babbling.Length; i++)
        {
            babbling[i] = babbling[i].Replace("aya", "x");
            babbling[i] = babbling[i].Replace("ye", "x");
            babbling[i] = babbling[i].Replace("woo", "x");
            babbling[i] = babbling[i].Replace("ma", "x");
            
            str = babbling[i].Replace("x", "");
            
            if (str == "")
            {
                answer++;
            }
        }
        
        return answer;
    }
}