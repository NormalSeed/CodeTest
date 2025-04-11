using System;
using System.Text;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        StringBuilder result = new StringBuilder();
        foreach(char c in my_string)
        {
            if (Char.IsUpper(c))
            {
                char c2 = Char.ToLower(c);
                result.Append(c2);
            }
            else
            {
                char c2 = Char.ToUpper(c);
                result.Append(c2);
            }
        }
        answer = result.ToString();
        
        return answer;
    }
}