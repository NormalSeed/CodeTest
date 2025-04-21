using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
        int answer = 2;
        
        foreach (string word in dic)
        {
            bool check = true;
            
            foreach (string c in spell)
            {
                if (word.IndexOf(c) == -1)
                {
                    check = false;
                    break;
                }
            }
            
            if (check == true)
            {
                answer = 1;
                break;
            }
        }
        
        return answer;
    }
}