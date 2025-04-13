using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string temp = "";
        
        foreach(char c in my_string)
        {
            if (char.IsDigit(c))
            {
                temp += c;
            }
            else
            {
                if (temp.Length > 0)
                {
                    answer += int.Parse(temp);
                    temp = "";
                }
            }
        }
        
        if (temp.Length > 0)
        {
            answer += int.Parse(temp);
        }
        
        return answer;
    }
}